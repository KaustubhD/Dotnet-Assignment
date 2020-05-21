namespace Assignment.Core
{
    public class ApiSalesAgent
    {
        public string Email { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public int BuilderId { get; set; }
        public Broker Broker { get; set; }
    }
}