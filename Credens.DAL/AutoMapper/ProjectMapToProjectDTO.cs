using AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.Infrastructure.DTO;

namespace Credens.DAL.AutoMapper
{
    public static class ProjectMapToProjectDTO 
    {
        public static Mapper MapperInit() 
        {
            var mapperConfig = new MapperConfiguration(x => x.CreateMap<Project, ProjectDTO>()
            .ForMember(x => x.Floor, x => x.MapFrom(x => x.OrderValue)));
            var mapper = new Mapper(mapperConfig);
           
            return mapper;
        }
    }
}
