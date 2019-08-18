using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using RandomMusicRest;

namespace SPconsumer
{
    class Consumer
    {
        public IList<sangpart> GetAllsp()
        {
            // laver en ny instance af HTTPClient der kan handle requests, using sørger for at den lukker forbindelsen efter brug
            using (HttpClient client = new HttpClient())
            {
                //laver en instance af typen string der tager imod HTTPClienten.
                // og klader en metode for at gette en værdi/value, dne taget en enkel parameter: REST URIen
                string content = client.GetStringAsync("http://localhost:63145/api/Music").Result;
                //create a instance of a list which takes the type Customer from library, the JsonConvert method deserializes the jason object and 
                //outputs it to the system 
                IList<sangpart> spList = JsonConvert.DeserializeObject<IList<sangpart>>(content);
                return spList;
            }
        }


        public bool Post(sangpart spobj)
        {
            // Laver body
            string json = JsonConvert.SerializeObject(spobj);
            StringContent content = new StringContent(json);
            // Her definerer vi at det er en Json vi sender og ikke eksempelvis XML
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (HttpClient client = new HttpClient())
            {
                // sender
                HttpResponseMessage resultMessage = client.PostAsync("http://localhost:63145/api/Music", content).Result;
                if (resultMessage.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;

            }
        }
    }
}
