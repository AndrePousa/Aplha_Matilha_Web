using Alpha_Matilha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Infrastructure.Context
{
    public class AlphaMatilhaContext : DbContext
    {
        public AlphaMatilhaContext(DbContextOptions<AlphaMatilhaContext> options) : base(options)
        {

        }

        //public DbSet<Person> Persons { get; set; }

        //public DbSet<Dog> Dogs { get; set; }

        //public DbSet<Classes_Dog> Classes_Dogs { get; set; }

        public DbSet<Address_Person> Address_Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlphaMatilhaContext).Assembly);
        }
    }
}
