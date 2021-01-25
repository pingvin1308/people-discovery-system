using System.ComponentModel.DataAnnotations;

namespace Pds.DataAccess.Entities
{
    public class Person
    {
        [Key]
        public long Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
    }
}
