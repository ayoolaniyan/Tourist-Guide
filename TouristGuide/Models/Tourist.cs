using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TouristGuide.Models
{
    public class Tourist
    {
        public int Id { get; set; }
        [Required]
        public string Location { get; set; }
        public string Itinerary { get; set; }
        public decimal Budget { get; set; }
        public string Type { get; set; }

        // Foreign Key
        public int CountryId { get; set; }
        // Navigation property
        public Country Country { get; set; }
    }
}