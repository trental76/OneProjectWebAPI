using OneProjectWebAPI.BL.Models;
using OneProjectWebAPI.BL.Models.Clients.Request;
using AutoMapper;

namespace OneProjectWebAPI.Mapper.Profiles;

public class UserModelProfile : Profile
{
    public UserModelProfile()
    {
        _ = CreateMap<CreateUserRequest, UserModel>()
            .ForMember(x => x.Id, opt => opt.Ignore());
    }
}
