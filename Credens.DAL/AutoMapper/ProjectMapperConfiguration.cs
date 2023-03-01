using AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.Infrastructure.DTO;

namespace Credens.DAL.AutoMapper
{
    public class ProjectMapperConfiguration
    {
        public ProjectMapperConfiguration() 
        {
            var mapperConfig = new MapperConfiguration(x => x.CreateMap<Project, ProjectDTO>()
            .ForMember(x => x.Floor, x => x.MapFrom(x => x.OrderValue)));
        }
    }
}
