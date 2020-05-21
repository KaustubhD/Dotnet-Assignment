namespace Assignment.Core
{
    public class HomeInfo
    {
        public int HomeId { get; set; }
        public int CommId { get; set; }
        public int PlanId { get; set; }
        public int ListingId { get; set; }
        public bool IsBasic { get; set; }
        public string CommName { get; set; }
        public string PlanName { get; set; }
        public bool IsSpec { get; set; }
        public int MarketId { get; set; }
        public int BuilderId { get; set; }
        public int Br { get; set; }
        public int Ba { get; set; }
        public int HBa { get; set; }
        public int St { get; set; }
        public int Gr { get; set; }
        public int Sft { get; set; }
        public float Price { get; set; }
        public string Addr { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Thumb1 { get; set; }
        public string Thumb2 { get; set; }
        public string IntImage { get; set; }
        public string Zip { get; set; }
        public string Status { get; set; }
        public string BrandLogo { get; set; }
        public ApiBrand Brand { get; set; }
        public string Phone { get; set; }
    }
}