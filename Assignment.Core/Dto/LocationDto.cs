using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    public class LocationDto
    {
        [Required]
        public int PartnerId { get; set; } = 9383;

        [Required]
        public string SearchTerm { get; set; } = "Dallas";

        public string Types { get; set; }

        public bool? IncludeAll { get; set; }
    }
}