using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EarthQ.Views.MenuPages
{
    public partial class EarthQMapPage : ContentPage
    {
        public Services service = new Services();
        public EarthQMapPage()
        {
            InitializeComponent();
            Title = "Haritada Depremler";
            GetEarthqukeMapsList();
        }

        public async void GetEarthqukeMapsList()
        {
            var myMap = await service.GetEarthqukeMaps();
            var Items = myMap.Earthquakes.Take(10);
            this.BindingContext = Items;

            foreach (var pins in Items)
            {
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(pins.Latitude, pins.Longitude),
                    Label = pins.Location
                };
                MyMap.Pins.Add(pin);

                MyMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                        new Position(pins.Latitude, pins.Longitude), Distance.FromMiles(800))); // Latitude, Longitude
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            TopStack.WidthRequest = width;
            TopStack.HeightRequest = height;
        }
    }
}
