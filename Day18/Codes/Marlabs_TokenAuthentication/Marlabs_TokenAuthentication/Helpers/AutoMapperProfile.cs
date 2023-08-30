using AutoMapper;
using Marlabs_TokenAuthentication.DTOs;
using Marlabs_TokenAuthentication.Models;

namespace Marlabs_TokenAuthentication.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LoginDTO, TblUser>();//Create Map-----------Implicit Mapping
            CreateMap<RegisterDTO, TblUser>();
        }
    }
}
