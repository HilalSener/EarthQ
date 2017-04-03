using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EarthQ.Views
{
    public partial class HomePage 
    {
        public Services service = new Services();
        public HomePage()
        {
            InitializeComponent();

            Title = "Deprem Listesi";
            GetEarthQListPage();

            Refresh.Clicked += delegate
            {
                GetEarthQListPage();
            };
        }

        public async void GetEarthQListPage()
        {
            var list = await service.GetEarthquke();
            lstView.BindingContext = list.Earthquakes;
        }
    }
}
