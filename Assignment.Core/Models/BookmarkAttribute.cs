using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Assignment.Core
{
    [AtLeastOne("ContentTypeName", "ContentTypeId")]
    #nullable enable
    public class BookmarkAttribute
    {
        public int? Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Initials { get; set; }
        public int? ContentTypeId { get; set; }

        /*
            Both ContentTypeId i.e 👆🏻 and
            ContentTypeName i.e 👇 are required but they are taken care of
            by the attribute on top
        */
        public string? ContentTypeName { get; set; }
        // [Required]
        public int ContentId { get; set; }
        // [Required]
        public string Title { get; set; }
        // [Required]
        public string Url { get; set; }
        [Required]
        [DefaultValue("Saved")]
        [JsonConverter(typeof(JsonStringEnumConverter))]

        public BookmarkActionType Action { get; set; }
        internal List<UserProfile>? SharedUsers { get; set; }
        internal List<BookmarkData>? BookmarkData { get; set; }

        // only needed for creating or editing bookmarks
        public string? Notes { get; set; }
    }
}