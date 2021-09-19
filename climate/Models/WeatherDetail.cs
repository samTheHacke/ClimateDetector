using System;
using System.Collections.Generic;

#nullable disable

namespace climate.Models
{
    public partial class WeatherDetail
    {
        public int Wid { get; set; }
        public string City { get; set; }
        public int? Temperature { get; set; }
        public int? Humidity { get; set; }
        public int? Visibility { get; set; }
    }
}
