using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    [AtLeastOne("UserId", "LogonName", ErrorMessage="One or more required properties were not supplied")]
    public class UserProfileDto
    {
        [Required]
        public string Partnerid { get; set; }
        public string UserId { get; set; }
        public string LogonName { get; set; }
        [DefaultValue(false)]
        public bool returnPassword { get; set; }
        [DefaultValue(false)]
        public bool ShowBookmarks { get; set; }
        [DefaultValue(false)]
        public bool ShowSharedUsers { get; set; }
        [DefaultValue(false)]
        public bool GetLinkedUsers { get; set; }
        [DefaultValue(false)]
        public bool ShowBoards { get; set; }
    }
}