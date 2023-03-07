using AutoMapper;

namespace Credens.Infrastructure.AutoMapper
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
