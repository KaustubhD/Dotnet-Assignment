using System.Collections.Generic;

namespace Assignment.Core
{
    public class ApiUrgencyResponse
    {
        public int CommunityId { get; set; }
        public Dictionary<string, Dictionary<string, int>> UrgencyData { get; set; }
    }
}