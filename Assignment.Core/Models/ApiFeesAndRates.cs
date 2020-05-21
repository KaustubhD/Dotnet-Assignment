namespace Assignment.Core
{
    public class ApiFeesAndRates
    {
        public string Description { get; set; }
        public string TypeCode { get; set; }
        public float MonthlyFee { get; set; }
        public float YearlyFee { get; set; }
        public int CommunityId { get; set; }
    }
}