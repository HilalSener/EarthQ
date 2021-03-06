﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthQ.Models
{
    public class Earthquake
    {
        public string Date { get; set; }
        public string FormattedDate
        {
            get
            {
                if (!string.IsNullOrEmpty(Date))
                {
                    return DateTime.Parse(Date).ToString("g");
                }
                return string.Empty;
            }
        }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Deepth { get; set; }
        public double Md { get; set; }
        public string Ml { get; set; }
        public double Mw { get; set; }
        public string Location { get; set; }
        public string Result { get; set; }
    }

    public class EarthQListModel
    {
        public ObservableCollection<Earthquake> Earthquakes { get; set; }
    }
}