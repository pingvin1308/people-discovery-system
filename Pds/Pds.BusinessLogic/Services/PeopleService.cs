using Pds.Domain.People;
using System.Threading.Tasks;

namespace Pds.BusinessLogic.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            this.peopleRepository = peopleRepository;
        }

        public async Task<Person[]> Get()
        {
            return await this.peopleRepository.Get();
        }
    }
}
