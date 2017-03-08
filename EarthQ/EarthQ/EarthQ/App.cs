﻿using EarthQ.CustomControls;
using EarthQ.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EarthQ
{
    public class App : Application
    {
        public static MasterDetailPage MenuPage;
        public static EarthQNavigationPage NavigationPage;

        public App()
        {
            var MenuPage = new MasterDetailPage();
            NavigationPage = new EarthQNavigationPage(new HomePage()) { BarBackgroundColor = Color.Orange };
            MenuPage.Master = new MenuPage();
            MenuPage.Detail = NavigationPage;
            MainPage = MenuPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}