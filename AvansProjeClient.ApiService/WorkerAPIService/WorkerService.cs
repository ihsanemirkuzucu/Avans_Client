using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.VM.AuthVMs;
using Newtonsoft.Json;

namespace AvansProjeClient.ApiService.WorkerAPIService
{
    public class WorkerService
    {
        HttpClient _client;

        public WorkerService(HttpClient client)
        {
            _client = client;
        }

        public async Task<LoginVM> LoginAsync(LoginVM loginVm)
        {
            StringContent str = new StringContent(JsonConvert.SerializeObject(loginVm));
            str.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage data = await _client.PostAsync("login", str);
            if (data.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<LoginVM>(await data.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<RegisterVM> RegisterAsync(RegisterVM registerVM)
        {
            StringContent str = new StringContent(JsonConvert.SerializeObject(registerVM));
            str.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage data = await _client.PostAsync("register", str);
            if (data.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<RegisterVM>(await data.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
