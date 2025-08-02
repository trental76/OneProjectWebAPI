using OneProjectWebAPI.BL.Commands.Users;
using MediatR;

namespace OneProjectWebAPI.Persistance.Users;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, long>
{
    private readonly LiteDBContext _liteDBContext;

    public CreateUserCommandHandler(LiteDBContext liteDBContext)
    {
        _liteDBContext = liteDBContext ?? throw new ArgumentNullException(nameof(liteDBContext));
    }

    public async Task<long> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var user = request.User;
        _liteDBContext.Users.Add(user);
        _ = await _liteDBContext.SaveChangesAsync();

        return user.Id;
    }
}
