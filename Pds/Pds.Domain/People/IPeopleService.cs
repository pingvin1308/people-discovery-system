using System;
using System.Threading.Tasks;

namespace Pds.Domain.People
{
    public interface IPeopleService
    {
        Task<Person[]> Get();
    }
}
