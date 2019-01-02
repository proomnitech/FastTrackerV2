using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FastTracker.Data.Models
{
    public class Clinic
    {
        public virtual int Id { get; set; }

        [MaxLength(1024)]
        public virtual string Name { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string PhoneExtension { get; set; }
        public virtual string FaxNumber { get; set; }
        public virtual string Website { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        //public virtual ICollection<Specialty> Specialties { get; set; }

        public string FullAddress(bool? twoLines)
        {
            var separator = ", ";
            if (twoLines.HasValue && twoLines.Value == true)
                separator = "<br />";

            if (!string.IsNullOrEmpty(Address1) && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(State) &&
                !string.IsNullOrEmpty(PostalCode))
            {
                return Address1 + separator + City + ", " + State + " " + PostalCode;
            }
            if (!string.IsNullOrEmpty(Address1) && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(State))
            {
                return Address1 + separator + City + ", " + State;
            }
            if (!string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(State))
            {
                return City + ", " + State;
            }
            return "";
        }
    }
}
