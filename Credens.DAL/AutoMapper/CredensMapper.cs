using AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.DAL.Type_selection;
using Credens.Infrastructure.DTO;

namespace Credens.DAL.AutoMapper
{
    public class CredensMapper<T> where T : class, new()
    {
        public static Mapper MapperInit() 
        {
            var reciveType = TypeSelect<T>.TypeSelection(new T());
            var mapperConfig = new MapperConfiguration(x => x.CreateMap <?, T>() ) ;
           
            var mapper = new Mapper(mapperConfig);
            return mapper;
        }
    }
}
