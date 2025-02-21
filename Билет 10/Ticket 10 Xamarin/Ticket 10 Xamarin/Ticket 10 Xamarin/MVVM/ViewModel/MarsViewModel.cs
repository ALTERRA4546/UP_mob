using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Ticket_10_Xamarin.MVVM.Model;

namespace Ticket_10_Xamarin.MVVM.ViewModel
{
    class MarsViewModel
    {
        public List<MarsModel> MarsModel { get; set; } = new List<MarsModel>();

        public async Task<List<MarsModel>> LoadMarsData()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync("https://android-kotlin-fun-mars-server.appspot.com/realestate");

                if (responseMessage.IsSuccessStatusCode)
                { 
                    HttpContent content = responseMessage.Content;
                    string json = await content.ReadAsStringAsync();

                    List<MarsModel> marsModels = JsonConvert.DeserializeObject<List<MarsModel>>(json);
                    return marsModels;
                }
            }

            return null;
        }
    }
}
