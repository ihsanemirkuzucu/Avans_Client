﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.VM.AdvanceVMs;
using AvansProjeClient.Models.VM.ProjectVMs;
using Newtonsoft.Json;

namespace AvansProjeClient.ApiService.AdvanceApiService
{
    public class AdvanceService
    {
        HttpClient _client;

        public AdvanceService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<ProjectVM>> AllProjectAsync()
        {
            var donenDeger = await _client.GetAsync("allproject");
            if (donenDeger.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProjectVM>>(await donenDeger.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<ProjectVM>> AllProjectsByWorkerIDAsync(int id)
        {
            var donenDeger = await _client.GetAsync($"allprojectbyworkerid/{id}");
            if (donenDeger.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ProjectVM>>(await donenDeger.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<string> AdvanceAddAsync(AdvanceAddVM advanceVM)
        {
            StringContent str = new StringContent(JsonConvert.SerializeObject(advanceVM));
            str.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var donenDeger = await _client.PostAsync("addadvance", str);
            if (donenDeger.IsSuccessStatusCode)
            {
                return await donenDeger.Content.ReadAsStringAsync();
            }
            return null;
        }

        public async Task<List<AdvanceApproveListVM>> AdvanceApproveListByWorkerIDAsync(int workerID)
        {
            var donenDeger = await _client.GetAsync($"advanceapprovelistbyworkerID/{workerID}");
            if (donenDeger.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<AdvanceApproveListVM>>(await donenDeger.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<AdvanceApproveVM> AdvanceApproveDetailsAsync(int advanceID)
        {
            var donenDeger = await _client.GetAsync($"advanceapprovedetails/{advanceID}");
            if (donenDeger.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<AdvanceApproveVM>(await donenDeger.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<WorkerAdvanceListVM>> WorkerAdvanceListAsync(int workerID)
        {
            var donenDeger = await _client.GetAsync($"workeradvancelist/{workerID}");
            if (donenDeger.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<WorkerAdvanceListVM>>(await donenDeger.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<AdvanceDetailsVM> AdvanceDetailsAsync(int advanceID)
        {
            var donenDeger = await _client.GetAsync($"advancedetails/{advanceID}");
            if (donenDeger.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<AdvanceDetailsVM>(await donenDeger.Content.ReadAsStringAsync());
            }
            return null;
        }



    }
}
