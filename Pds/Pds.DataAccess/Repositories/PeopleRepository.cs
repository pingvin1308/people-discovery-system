using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pds.Domain.People;
using System.Threading.Tasks;

namespace Pds.DataAccess.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly PdsContext context;
        private readonly IMapper mapper;

        public PeopleRepository(PdsContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Person[]> Get()
        {
            var people = await this.context.People.ToListAsync();

            return this.mapper.Map<Person[]>(people);
        }
    }
}
