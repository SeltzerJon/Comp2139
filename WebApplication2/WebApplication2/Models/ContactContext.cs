using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext>options)
            :base(options) { }

        public DbSet<Contact> Contacts { get; set;}

        public DbSet<Catergory> Catergories { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catergory>().HasData(
                new Catergory { CatergoryId = 1, Name = "Friend" },
                new Catergory { CatergoryId = 2, Name = "Work" },
                new Catergory { CatergoryId = 3, Name = "Family" },
                new Catergory { CatergoryId = 4, Name = "Other" }
                
                );

            modelBuilder.Entity<Contact>().HasData(

                new Contact
                {
                    ContactId = 1,
                    FirstName = "Peter",
                    LastName = "Bob",
                    Phone = "647-929-7213",
                    Email = "Peter.bob@gm.com",
                    CatergoryId = 1,
                    DateAdded= DateTime.Now,
                },


                new Contact
                {
                    ContactId = 2,
                    FirstName = "Joe",
                    LastName = "Bob",
                    Phone = "647-949-7213",
                    Email = "Peter.bobasassas@gm.com",
                    CatergoryId = 2,
                    DateAdded = DateTime.Now,
                }

                );;
        }
    }
}
