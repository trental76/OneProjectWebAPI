using OneProjectWebAPI.BL.Models.Clients.Requests;

namespace OneProjectWebAPI.BL.Models.Clients.Request;

public class CreateUserRequest
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }
}
