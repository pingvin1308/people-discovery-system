using System.Threading.Tasks;

namespace Pds.Domain.People
{
    public interface IPeopleRepository
    {
        Task<Person[]> Get();
    }
}
