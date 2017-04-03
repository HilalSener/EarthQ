using System;
using EarthQ.CustomControls;
using EarthQ.Models;
using EarthQ.Views.MenuPages;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace EarthQ.Views
{
    public partial class MenuPage : ContentPage
    {
        ObservableCollection<MenuModel> menuItems = new ObservableCollection<MenuModel>();
        EarthQNavigationPage earthQMap = new EarthQNavigationPage(new EarthQMapPage()) { BarBackgroundColor = Color.Orange };
        EarthQNavigationPage earthQSetting = new EarthQNavigationPage(new SettingsPage()) { BarBackgroundColor = Color.Orange };
        public MenuPage()
        {
            InitializeComponent();
            Title = "Menü";
            Icon = "Menu.png";

            menuItems.Add(new MenuModel("Deprem Listesi", "Resources/List.png", App.DetailPage));
            menuItems.Add(new MenuModel("Haritada Depremler", "Resources/Earth.png", earthQMap));
            menuItems.Add(new MenuModel("Ayarlar", "Resources/Settings.png", earthQSetting));
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
