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
        public int Id { get; set; }
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
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        [Required] // Needed for form filling
        [DefaultValue("Saved")] // Needed for displaying on the swagger page
        [JsonConverter(typeof(JsonStringEnumConverter))]

        public BookmarkActionType Action { get; set; }
        internal List<UserProfile>? SharedUsers { get; set; }
        internal List<BookmarkData>? BookmarkData { get; set; }
        public List<string> Notes { get; set; }
    }
}