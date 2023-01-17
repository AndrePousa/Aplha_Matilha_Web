using Alpha_Matilha_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Alpha_Matilha_Backend.Repository.Context
{
    public class AlphaMatilhaContext : DbContext
    {
        public AlphaMatilhaContext(DbContextOptions<AlphaMatilhaContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }

        public DbSet<Dog> Dog { get; set; }

        public DbSet<Classes_Dog> Classes_Dog { get; set; }

        public DbSet<Address_Person> Address_Person { get; set; }
    }
}
