using System;

namespace Assignment.Core
{
    public class UserProfileShare
    {
        public UserProfile SourceUser { get; set; }
        public UserProfile SharedUser { get; set; }
        public string UserSharedEmail { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}