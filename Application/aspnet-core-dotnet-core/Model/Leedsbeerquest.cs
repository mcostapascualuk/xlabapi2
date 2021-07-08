using System;
using System.ComponentModel.DataAnnotations;

namespace xlabapi.Model
{
    public class Leedsbeerquest
    {
        [Key]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
        public string  Excerpt { get; set; }
        public string Thumbnail { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Twitter { get; set; }
        public string Stars_beer { get; set; }
        public string Stars_atmosphere { get; set; }
        public string Stars_amenities { get; set; }
        public string Stars_value { get; set; }
        public string Tags { get; set; }
    }
}
