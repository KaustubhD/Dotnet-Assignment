using System;
using System.Collections.Generic;

namespace Assignment.Core
{
    public class UserProfile
    {
        public string UserId { get; set; }
        public string LogonName { get; set; }
        public string PartnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Initials { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string PhoneExt { get; set; }
        public string RegMetro { get; set; }
        public string SsoId { get; set; }
        public string ImageUrl { get; set; }
        public int MoveInDate { get; set; }
        public int FinancePreference { get; set; }
        public int Reason { get; set; }
        public int AgeRange { get; set; }
        public int HomePrefence { get; set; }
        public string Password { get; set; }
        public byte AccountStatus { get; set; }
        public UserProfile LinkedUser { get; set; }
        public DateTime DateRegistered { get; set; }
        public string LeadOptIn { get; set; }
        public bool RegBOYLInterest { get; set; }
        public bool RegComingSoonInterest { get; set; }
        public bool RegActiveAdultInterest { get; set; }
        public bool WeeklyOptIn { get; set; }
        public bool WeeklyHomeOptIn { get; set; }
        public bool MarketOptIn { get; set; }
        public bool MailList { get; set; }
        public List<BookmarkAttribute> Bookmarks { get; set; }
        public List<UserProfileShare> SharedUserProfiles { get; set; }
        public List<BookmarkAttribute> Boards { get; set; }
        public UserProfileShareStatus InvitationStatus { get; set; }
    }
}