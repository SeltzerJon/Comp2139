using Microsoft.EntityFrameworkCore;

namespace database.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Friend" },
                new Category { CategoryId = 2, Name = "Work" },
                new Category { CategoryId = 3, Name = "Family" },
                new Category { CategoryId = 4, Name = "Other" }
            );
            modelBuilder.Entity<Contact>().HasData(

                new Contact
                {
                    ContactId = 1,
                    FirstName = "Peter",
                    LastName = "Bob",
                    Phone = "647-929-7213",
                    Email = "Peter.bob@gm.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now,
                },


                new Contact
                {
                    ContactId = 2,
                    FirstName = "Joe",
                    LastName = "Bob",
                    Phone = "647-949-7213",
                    Email = "Peter.bobasassas@gm.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now,
                }

                ); ;
        }

    }
}
