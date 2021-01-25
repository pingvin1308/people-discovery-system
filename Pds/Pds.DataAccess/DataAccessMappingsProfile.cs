using AutoMapper;
using Pds.Domain.People;

namespace Pds.DataAccess
{
    public class DataAccessMappingsProfile : Profile
    {
        public DataAccessMappingsProfile()
        {
            CreateMap<Entities.Person, Person>()
                .ReverseMap();
        }
    }
}
