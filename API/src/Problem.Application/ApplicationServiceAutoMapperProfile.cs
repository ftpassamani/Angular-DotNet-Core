using AutoMapper;
using Problem.Application.Log.Dto;
using Problem.Application.Users.Dto;
using Problem.Core.Log;
using Problem.Core.Users;

namespace Problem.Application
{
    public class ApplicationServiceAutoMapperProfile : Profile
    {
        public ApplicationServiceAutoMapperProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(u => u.Password, opt => opt.Ignore());

            CreateMap<LogAcesso, LogAcessoOutput>();
        }
    }
}