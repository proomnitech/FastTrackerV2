using System;
using System.Collections.Generic;

namespace FastTracker.Data.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public virtual Clinic Clinic { get; set; }

        public virtual ICollection<License> Licenses { get; set; }
    }
}
