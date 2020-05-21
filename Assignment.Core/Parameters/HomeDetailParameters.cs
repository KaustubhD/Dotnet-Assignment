using System.ComponentModel.DataAnnotations;

namespace Assignment.Core
{
    public class HomeDetailParameters
    {
        [Required]
        public int PartnerId  { get; set; }
        [Required]
        public int planId {get; set; }
        public int specId {get; set; }
        public int backFillImages {get; set; }
        public int includeBookMarks {get; set; }
        public string userId {get; set; }
        public bool? excludeHomeOptions { get; set; }
        public bool? excludeutilities { get; set; }
        public bool? excludeVideos { get; set; }
        public bool? excludeNonPdfBrochure { get; set; }
        public bool? includeUrgencyData { get; set; }
        public bool? excludeCustomAmenities { get; set; }
        public bool? excludeTollFreeNumber { get; set; }
        public bool? excludeBuilderMap { get; set; }
        public bool? includeBrandShowcase { get; set; }
        public bool? excludeAgents { get; set; }
        public bool? excludeCommunityMap { get; set; }
        public bool? excludeEnvisionUrl { get; set; }
        public bool? setSphericalAtTheEnd { get; set; }
        public bool? excludeDescription { get; set; }
        public bool? excludeSchoolDistricts { get; set; }
        public bool? excludeFloorPlanViewerUrl { get; set; }
        public bool? includeSphericalImages { get; set; }
        public bool? excludeImages { get; set; }
        public bool? excludeSummary { get; set; }
        public bool? includeVideoUrls { get; set; }
        public bool? includeBookmarks { get; set; }
        public bool? aggregateOptions { get; set; }
        public bool? excludeFeesAndTaxes { get; set; }        
    }
}