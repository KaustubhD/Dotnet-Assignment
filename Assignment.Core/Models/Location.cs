using System;

namespace Assignment.Core
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string MarketStateAbbr { get; set; }
        public string MarketStateName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool HasShowCase { get; set; }
        public string BrandType { get; set; }
        
        public Location()
        {

        }
    }
}
