using AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.Infrastructure.DTO;

namespace Credens.DAL.AutoMapper
{
    public class CredensMapper<TIn, TOut> 
    {
        public static Mapper MapperInit() 
        {
            var mapperConfig = new MapperConfiguration(x => x.CreateMap<TIn, TOut>());
            var mapper = new Mapper(mapperConfig);
            return mapper;
        }
    }
}
