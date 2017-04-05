using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using EarthQ.Models;

namespace EarthQ
{
    public class Services
    {
        public async Task<EarthQListModel> GetEarthquke()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://sondepremler20160728065405.azurewebsites.net/");
                client.DefaultRequestHeaders.Add("Accept", "appliction/json");
                var response = client.GetAsync("last"); 
                var result = await response.Result.Content.ReadAsStringAsync();
                var myreturn = JsonConvert.DeserializeObject<EarthQListModel>(result);

                return myreturn;
            }
        }

        public async Task<EarthQListModel> GetEarthqukeMaps()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://sondepremler20160728065405.azurewebsites.net/");
                client.DefaultRequestHeaders.Add("Accept", "appliction/json");
                var response = client.GetAsync("last");
                var result = await response.Result.Content.ReadAsStringAsync();
                var myreturn = JsonConvert.DeserializeObject<EarthQListModel>(result);

                return myreturn;
            }
        }
    }
}
