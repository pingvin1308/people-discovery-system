using Microsoft.EntityFrameworkCore;
using Pds.DataAccess.Entities;

namespace Pds.DataAccess
{
    public class PdsContext : DbContext
    {
        public PdsContext(DbContextOptions<PdsContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }   
    }
}
