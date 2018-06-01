using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LuisDelValle.TimesheetSolution.WebApp.Services
{
    public class RestClient<T> : IRestClient<T> where T : class
    {
        public string Host { get; set; }
        public string Path { get; set; }

        private static HttpClient Client = new HttpClient();

        public async Task<T> GetResponseAsync()
        {
            var stringResponse = await Client.GetStringAsync(Host + Path);

            if (stringResponse != null)
            {
                T response = JsonConvert.DeserializeObject<T>(stringResponse);

                if (response != null)
                {
                    return response;
                }
            }

            return null;
        }
    }
}
