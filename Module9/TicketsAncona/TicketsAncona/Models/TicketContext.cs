using Microsoft.EntityFrameworkCore;

namespace TicketsAncona.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }

        public DbSet<Ticket> Tickets { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "toDo", Name = "To Do" },
                new Status { StatusId = "inProgress", Name = "In Progress" },
                new Status { StatusId = "qa", Name = "QA" },
                new Status { StatusId = "done", Name = "Done" }
            );
        }
    }
}
