using EarthQ.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthQ.Models
{
    public class MenuModel
    {
        public string MenuItemName { get; set; }
        public string MenuIconName { get; set; }
        
        public MenuModel(string name, string icon, EarthQNavigationPage nav)
        {
            this.MenuItemName = name;
            this.MenuIconName = icon;
            this._nav = nav;
        }
        public EarthQNavigationPage _nav;
    }
}
