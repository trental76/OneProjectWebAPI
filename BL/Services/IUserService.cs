using OneProjectWebAPI.BL.Models;
using OneProjectWebAPI.BL.Models.Clients.Request;
using OneProjectWebAPI.BL.Models.Clients.Requests;

namespace OneProjectWebAPI.BL.Services;

public interface IUserService
{
    Task<IReadOnlyCollection<UserModel>> GetUsers(GetUsersRequest getUsersRequest);

    Task<long> CreateUser(CreateUserRequest user);
}
