using OneProjectWebAPI.BL.Models;
using OneProjectWebAPI.BL.Queries.Users;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace OneProjectWebAPI.Persistance.Users;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IReadOnlyCollection<UserModel>>
{
    private readonly LiteDBContext _liteDBContext;

    public GetUsersQueryHandler(LiteDBContext liteDBContext)
    {
        _liteDBContext = liteDBContext ?? throw new ArgumentNullException(nameof(liteDBContext));   
    }

    public async Task<IReadOnlyCollection<UserModel>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        if (request.FilterExpressionModel == null)
        {
            return _liteDBContext.Users.OrderBy(x => x.Id)
            .Skip(request.PaginationModel.PageSize * (request.PaginationModel.PageNumber - 1))
            .Take(request.PaginationModel.PageSize)
            .ToList();
        }

        return _liteDBContext.Users
                .Where(request.FilterExpressionModel)
                .OrderBy(x => x.Id)
                .Skip(request.PaginationModel.PageSize * (request.PaginationModel.PageNumber - 1))
                .Take(request.PaginationModel.PageSize)
                .ToList();
    }
}
