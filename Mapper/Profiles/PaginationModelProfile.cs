using OneProjectWebAPI.BL.Models;
using OneProjectWebAPI.BL.Models.Clients.Requests;
using AutoMapper;

namespace OneProjectWebAPI.Mapper.Profiles;

public class PaginationModelProfile : Profile
{
    public PaginationModelProfile()
    {
        _ = CreateMap<GetUsersRequest, PaginationModel>();
    }
}
