using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FastTracker.Data.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }

        [MaxLength(255)]
        public string ServiceCategory { get; set; }
        public string Definition { get; set; }
        public string EligibleRecipients { get; set; }
        public string CoveredServices { get; set; }
        public string EligibleProviders { get; set; }
        public string DetailsPage { get; set; }
        public string DetailsLink { get; set; }
        public bool RequiresApproval { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual ICollection<Clinic> Clinics { get; set; }
        public virtual ICollection<Availability> Availabilities { get; set; }
    }
}
