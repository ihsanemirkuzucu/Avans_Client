using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.VM.AuthVMs;
using AvansProjeClient.Models.VM.TitleVMs;
using AvansProjeClient.Models.VM.UnitVMs;
using Newtonsoft.Json;

namespace AvansProjeClient.ApiService.AuthApiService
{
    public class AuthService
    {
        HttpClient _client;

        public AuthService(HttpClient client)
        {
            _client = client;
        }

        public async Task<RequiredDataVM> GetRequiredDataAsync()
        {
            var datas = await _client.GetAsync("requireddata");
            if (datas.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<RequiredDataVM>(await datas.Content.ReadAsStringAsync());
                return data;
            }
            return null;
        }

        public async Task<List<TitleVM>> GetTitleAsync()
        {
            var datas = await _client.GetAsync("alltitle");
            if (datas.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<List<TitleVM>>(await datas.Content.ReadAsStringAsync());
                return data;
            }
            return null;
        }

        public async Task<List<UnitVM>> GetUnitAsync()
        {
            var datas = await _client.GetAsync("allunit");
            if (datas.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<List<UnitVM>>(await datas.Content.ReadAsStringAsync());
                return data;
            }
            return null;
        }
    }
}
