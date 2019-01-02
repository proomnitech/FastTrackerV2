using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FastTracker.Data.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        [StringLength(255)]
        public virtual string EmailAddress { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public virtual ICollection<Clinic> Clinics { get; set; }
        public bool RequirePasswordChange { get; set; }
    }
}
