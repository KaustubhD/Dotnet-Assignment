using System.Collections.Generic;

namespace Assignment.Core
{
    public class BookmarkData
    {
        public int Id { get; set; }
        public BookmarkActionType Action { get; set; }
        public string UserId { get; set; }
        public string BoardOwnerUserId { get; set; }
        public string UserContent { get; set; }
        public BookmarkContentType ContentType { get; set; }
        public List<int> ContentIds { get; set; }
        public List<int> BookmarkIds { get; set; }
        public List<UserActions> UserActions { get; set; }
        public ImageInfo ImageInfo { get; set; }
        public HomeInfo HomeInfo { get; set; }
    }
}