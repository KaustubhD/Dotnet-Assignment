namespace Assignment.Core
{
    public class ApiBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Phone {get; set; }
        public bool AllowUTMTracking {get; set; }
        public string State {get; set; }
        public int PreferredScore {get; set; }
        public int ParentBuilderId {get; set; }
        public string CustomMortgageLink {get; set; }
    }
}