using System;
using System.ComponentModel.DataAnnotations;

namespace FastTracker.Data.Models
{
    public class ZipGeocode
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Zip { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
    }
}
