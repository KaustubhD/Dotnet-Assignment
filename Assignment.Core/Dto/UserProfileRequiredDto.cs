using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    public class UserProfileRequiredDto
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string LogonName { get; set; }
        [Required]
        public string PartnerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string RegMetro { get; set; }
        [Required]
        public string Password { get; set; }
    }
}