using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    public class UserBookmarksDto: UserBasicDto
    {
        public bool? ShowNotes { get; set; }
        public bool? ShowSharedUsers { get; set; }
        public bool? ShowSharedBookmarks { get; set; }
        public bool? GetLastElement { get; set; }
        public BookmarkActionType? actionName { get; set; }
        public int? ContentTypeId { get; set; }
        #nullable enable
        public string? ContentTypeName { get; set; }
    }
}
