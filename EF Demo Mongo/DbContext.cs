using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Demo_Mongo
{
    public class dbContext : DbContext
    {
       public DbSet<Consumer> Consumers { get; set; }

        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Consumer>(
                b =>
                {
                  b.ToCollection("Consumers");
                  b.Property(c => c.Name).HasElementName("Name");
                  b.OwnsMany(c => c.Addresses);
                 
                });
        }   
 
    }
}
