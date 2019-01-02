using System;
using System.Collections.Generic;

namespace FastTracker.Data.Models
{
    public class AvailabilityType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? AvailabilityInWeeks { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual ICollection<Availability> Availabilities { get; set; }
    }
}
