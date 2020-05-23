using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    public class UserProfileDto: UserBasicDto
    {
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