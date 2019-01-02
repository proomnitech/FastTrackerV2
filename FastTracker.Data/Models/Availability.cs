using System;

namespace FastTracker.Data.Models
{
    public class Availability
    {
        public int Id { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual Service Service { get; set; }
        public virtual AvailabilityType AvailabilityTypes { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
    }
}
