using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EarthQ.CustomControls
{
    public class EarthQNavigationPage :NavigationPage
    {
        public EarthQNavigationPage(ContentPage mainPage):base(mainPage)
		{
            this.BarTextColor = Color.White;
            this.BarBackgroundColor = Color.FromHex("#2E97D3");
        }
        public EarthQNavigationPage()
        {
            this.BarTextColor = Color.White;
            this.BarBackgroundColor = Color.FromHex("#2E97D3");
        }
        public EarthQNavigationPage(TabbedPage mainPage) : base(mainPage)
		{
            this.BarTextColor = Color.White;
            this.BarBackgroundColor = Color.FromHex("#2E97D3");
        }
    }
}
