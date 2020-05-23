using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    [AtLeastOne("userId", "logonName", ErrorMessage="One or more required properties were not supplied")]
    public class UserBasicDto
    {
        [Required]
        public string partnerid { get; set; }
        public string userId { get; set; }
        public string logonName { get; set; }
    }
}
