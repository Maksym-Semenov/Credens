using AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.DAL.Type_selection;
using Credens.Infrastructure.DTO;

namespace Credens.DAL.AutoMapper
{
    public class CredensMapper<K,T> where T : class, new()
    {
        public static Mapper MapperInit() 
        {
            var mapperConfig = new MapperConfiguration(x => x.CreateMap <K, T>() ) ;
            var mapper = new Mapper(mapperConfig);
            return mapper;
        }
    }
}
