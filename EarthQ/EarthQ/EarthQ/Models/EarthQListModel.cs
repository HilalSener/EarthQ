using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthQ.Models
{
    public class Earthquake
    {
        public string Date { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Deepth { get; set; }
        public double MD { get; set; }
        public double ML { get; set; }
        public double MW { get; set; }
        public string Location { get; set; }
        public string Result { get; set; }
    }

    public class EartQList
    {
        public List<Earthquake> earthquakes { get; set; }
    }
}
