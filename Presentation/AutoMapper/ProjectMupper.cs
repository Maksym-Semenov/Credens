using AutoMapper;
using Credens.Infrastructure.DTO;
using Credens.Presentation.ViewModels;

namespace Credens.Presentation.AutoMapper
{
    public class ProjectMupper
    {
        public ProjectMupper()
        {
            var mapConfig = new MapperConfiguration(x => x.CreateMap<ProjectDTO, ProjectViewModel>());
            //var mapper = new Mapper(mapConfig);
        }
    }
}
