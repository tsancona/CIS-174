using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TicketsAncona.Models
{
    public class TicketViewModel
    {
        [ValidateNever]
        public Filters Filters { get; set; } = null!;
        [ValidateNever]
        public List<Status> Statuses { get; set; } = null!;
        [ValidateNever]
        public List<Ticket> Tickets { get; set; } = null!;
        public Ticket CurrentTicket { get; set; } = null!;
    }
}
