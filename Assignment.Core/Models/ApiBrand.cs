namespace Assignment.Core
{
    public class ApiBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BuilderId { get; set; }
        public string Logo{ get; set; }
        public string LogoSmall { get; set; }
        public int MarketId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string SiteUrl { get; set; }
        public int ShowCaseStatusId { get; set; }
        public int IsBasic { get; set; }
        public int HasShowCase { get; set; }
        public int TotalHome { get; set; }
        public int CommunityCount { get; set; }
        public int BoyICount { get; set; }
        public int ModularCount { get; set; }
        public int CustomCount { get; set; }
        public int CustomBuilderCount { get; set; }
        public int PlanCount { get; set; }
        public int SpecCount { get; set; }
        public int UnderContructionCount { get; set; }
        public int GalleryCount { get; set; }
        public string ShowMortgageLink { get; set; }
        public string CustomMortgageLink { get; set; }
        public int TestimonialCount { get; set; }
        public int IsBoyl{ get; set; }
        public int IsModularBuilder { get; set; }
        public int IsCustomBuilder { get; set; }
        public int IsNewCustomBuilderLocation { get; set; }
        public string Overview { get; set; }
        public string Description{ get; set; }
        public string RssFeed { get; set; }
        public string TwitterWidget { get; set; }
        public string FacebookWidget { get; set; }
        public string BrandUrl { get; set; }
        public string ContactEmail { get; set; }
        // public ApiCommunityResultV2 Location { get; set; }
        public bool HasBuilderReviews { get; set; }
    }
}