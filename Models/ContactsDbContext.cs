using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactsManagement.Models
{
    public class ContactsDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(c => c.FirstName).IsRequired().HasMaxLength(200); //FirstName is required so its not nullable
            modelBuilder.Entity<Contact>()
    .Property(c => c.LastName).IsRequired().HasMaxLength(200); //LastName is required so its not nullable
            modelBuilder.Entity<Contact>()
.Property(c => c.Email).IsRequired().HasMaxLength(200); //email is required so its not nullable
        }

    }
}
