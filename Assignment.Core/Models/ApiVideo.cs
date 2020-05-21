namespace Assignment.Core
{
    public class ApiVideo
    {
        public string NhsVideoId { get; set; }
        public string BcRefId { get; set; }
        public int BuilderId { get; set; }
        public int PlanId { get; set; }
        public int CommunityId { get; set; }
        public int Sort { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string ThumbnailUrl{ get; set; }
    }
}