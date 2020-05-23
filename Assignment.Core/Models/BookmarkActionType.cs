using System.Runtime.Serialization;

namespace Assignment.Core
{
    public enum BookmarkActionType
    {
        [EnumMember(Value = "Saved")]
        Saved = 1,
        [EnumMember(Value = "Like")]
        Like = 2,
        [EnumMember(Value = "Dislike")]
        Dislike = 3,
        [EnumMember(Value = "Board")]
        Board = 4,
        [EnumMember(Value = "Lead")]
        Lead = 5,
        [EnumMember(Value = "Reco")]
        Reco = 6,
        [EnumMember(Value = "Neutral")]
        Neutral = 7
    }
}