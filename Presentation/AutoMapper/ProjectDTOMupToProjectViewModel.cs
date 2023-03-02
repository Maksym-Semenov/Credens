using AutoMapper;
using Credens.Infrastructure.DTO;
using Credens.Presentation.ViewModels;

namespace Credens.Presentation.AutoMapper
{
    public class ProjectDTOMupToProjectViewModel
    {
         public static Mapper InitAutomapper()
        {
            var mapConfig = new MapperConfiguration(x => x.CreateMap<ProjectDTO, ProjectViewModel>()
            .ForMember(src => src.Name, dest => dest.MapFrom(dest => dest.OrderName))
            .ForMember(src => src.Price, dest => dest.MapFrom(dest => dest.Price))
            .ForMember(src => src.Id, dest => dest.MapFrom(dest => dest.ProjectId))
            );
            var mapper = new Mapper(mapConfig);
            return mapper;
        }
    }
}
