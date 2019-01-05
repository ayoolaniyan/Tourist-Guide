using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristGuide.Models
{
    public class TouristDetailDTO
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Itinerary { get; set; }
        public decimal Budget { get; set; }
        public string CountryName { get; set; }
        public string Type { get; set; }
    }
}