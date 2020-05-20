using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    public class LocationParameters
    {
        [Required]
        public int PartnerId { get; set; }

        [Required]
        public string SearchTerm { get; set; }

        public string Types { get; set; }

        public bool? IncludeAll { get; set; }
    }
}