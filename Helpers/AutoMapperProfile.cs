using AutoMapper;
using PixForce.Entities;
using PixForce.Dtos;
using PixForce.Dtos.Param;

namespace PixForce.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region USER
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<User, UserParamDto>();
            CreateMap<UserParamDto, User>();
            #endregion

            #region
            CreateMap<Estoque, EstoqueDto>();
            CreateMap<EstoqueDto, Estoque>();
            CreateMap<Estoque, EstoqueParamDto>();
            CreateMap<EstoqueParamDto, Estoque>();
            #endregion
        }
    }
}