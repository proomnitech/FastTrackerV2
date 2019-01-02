using System;
using System.Collections.Generic;

namespace FastTracker.Data.Models
{
    public class InsurancePlan
    {
        public int Id { get; set; }
        public string Plan { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual ICollection<Clinic> Clinics { get; set; }
    }
}
