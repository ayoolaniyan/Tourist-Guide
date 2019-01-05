using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristGuide.Models
{
    public class TouristDTO
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string CountryName { get; set; }
    }
}