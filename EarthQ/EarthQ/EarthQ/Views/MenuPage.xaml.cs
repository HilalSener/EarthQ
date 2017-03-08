using EarthQ.CustomControls;
using EarthQ.Models;
using EarthQ.Views.MenuPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EarthQ.Views
{
    public partial class MenuPage : ContentPage
    {
        ObservableCollection<MenuModel> menuItems = new ObservableCollection<MenuModel>();
        EarthQNavigationPage earthQMap = new EarthQNavigationPage(new EarthQMapPage());

        public MenuPage()
        {
            InitializeComponent();
            Title = "Menü";
            Icon = "Menu.png";

            menuItems.Add(new MenuModel("Earthquake List", "Resources/List.png", App.NavigationPage));
            menuItems.Add(new MenuModel("Earthqake Map", "Resources/Earth.png", earthQMap));
            MenuList.ItemsSource = menuItems;
            MenuList.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                var item = e.Item as MenuModel;
                App.MenuPage.Detail = item._nav;
                App.MenuPage.IsPresented = false;
                MenuList.SelectedItem = null;
            };
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
        }
    }
}
