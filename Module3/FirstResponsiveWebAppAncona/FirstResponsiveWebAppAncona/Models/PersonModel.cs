using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppAncona.Models
{
    public class PersonModel
    {
        private const int CurrentYear = 2023;

        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your birth year.")]
        [Range(1900, 2023, ErrorMessage = "Your birth year must be between 1900 and 2023.")]
        public int? BirthYear { get; set; }

        public int? AgeThisYear()
        {
            return CurrentYear - BirthYear;
        }
    }
}
