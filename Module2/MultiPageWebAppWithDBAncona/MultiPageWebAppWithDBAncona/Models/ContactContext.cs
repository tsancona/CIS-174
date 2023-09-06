using Microsoft.EntityFrameworkCore;

namespace MultiPageWebAppWithDBAncona.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(
                new Contact 
                {
                    ContactId = 1,
                    Name = "Lisa Jefferson",
                    PhoneNumber = "515-555-1234",
                    Address = "123 This Way, Des Moines, IA 51234",
                    Note = "Met at school"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Bill Jameson",
                    PhoneNumber = "515-555-5678",
                    Address = "123 That Way, Des Moines, IA 55678",
                    Note = "Friend of Lisa"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Steve Stevens",
                    PhoneNumber = "515-555-1357",
                    Address = "123 Other Way, Des Moines, IA 51357",
                    Note = "From math class"
                }
            );
        }
    }
}
