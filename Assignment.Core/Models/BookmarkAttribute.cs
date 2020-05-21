using System.Collections.Generic;

namespace Assignment.Core
{
    public class BookmarkAttribute
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public int ContentTypeId { get; set; }
        public string ContentTypeName { get; set; }
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public BookmarkActionType Action { get; set; }
        public List<UserProfile> SharedUsers { get; set; }
        public List<BookmarkData> BookmarkData { get; set; }
    }
}