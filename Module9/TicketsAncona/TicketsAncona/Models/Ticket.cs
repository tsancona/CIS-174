using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TicketsAncona.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a sprint number.")]
        public string SprintNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a point value.")]
        public string PointValue { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;
    }
}
