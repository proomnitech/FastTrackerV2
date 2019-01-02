using System;
using System.Collections.Generic;

namespace FastTracker.Data.Models
{
    public class License
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual ICollection<Provider> Providers { get; set; }
    }
}
