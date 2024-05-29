using Microsoft.EntityFrameworkCore;
using SharedModels;

namespace WebApi2.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options) {
        
        }

        public DbSet<Person> Persons { get; set; }

    }
}
