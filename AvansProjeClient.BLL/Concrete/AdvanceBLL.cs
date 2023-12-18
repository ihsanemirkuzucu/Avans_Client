using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.ApiService.AdvanceApiService;
using AvansProjeClient.BLL.Abstract;
using AvansProjeClient.Models.GeneralReturn;
using AvansProjeClient.Models.VM.AdvanceVMs;
using AvansProjeClient.Models.VM.ProjectVMs;

namespace AvansProjeClient.BLL.Concrete
{
    public class AdvanceBLL : IAdvanceBLL
    {
        private AdvanceService _api;

        public AdvanceBLL(AdvanceService api)
        {
            _api = api;
        }

        public async Task<GeneralReturnType<List<AdvanceApproveListVM>>> GetAdvanceApproveListByWorkerIDAsync(int workerID)
        {
            try
            {
                return new GeneralReturnType<List<AdvanceApproveListVM>>(await _api.AdvanceApproveListByWorkerIDAsync(workerID), true, "Onay Listesi Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdvanceApproveListVM>>(null, false, "Onay Listesi Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<List<WorkerAdvanceListVM>>> GetWorkerAdvanceListAsync(int workerID)
        {
            try
            {
                return new GeneralReturnType<List<WorkerAdvanceListVM>>(await _api.WorkerAdvanceListAsync(workerID), true, "Çalışan Avanas Listesi Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<WorkerAdvanceListVM>>(null, true, "Çalışan Avanas Listesi Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<AdvanceDetailsVM>> GetAdvanceDetailsAsync(int advanceID)
        {
            try
            {
                return new GeneralReturnType<AdvanceDetailsVM>(await _api.AdvanceDetailsAsync(advanceID), true, "Avans Detayları Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdvanceDetailsVM>(null, false, "Avans Detayları Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<AdvanceApproveVM>> GetAdvanceApproveDetailsAsync(int advanceID)
        {
            try
            {
                return new GeneralReturnType<AdvanceApproveVM>(await _api.AdvanceApproveDetailsAsync(advanceID), true,"Avans Detayları Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdvanceApproveVM>(null, false, "Avans Detayları Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<string>> AdvanceAddAsync(AdvanceAddVM advanceAddVM)
        {
            try
            {
                return new GeneralReturnType<string>(await _api.AdvanceAddAsync(advanceAddVM), true, "Avans Talebi Eklendi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<string>(ex.Message, false, "Avans Talebi Eklenemedi");
            }
        }

        public async Task<GeneralReturnType<List<ProjectVM>>> GetAllProjectAsync()
        {
            try
            {
                return new GeneralReturnType<List<ProjectVM>>(await _api.AllProjectAsync(), true, "Projeler Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<ProjectVM>>(null, true, "Projeler Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<List<ProjectVM>>> GetAllProjectsByWorkerIDAsync(int id)
        {
            try
            {
                return new GeneralReturnType<List<ProjectVM>>(await _api.AllProjectsByWorkerIDAsync(id), true, "Çalışanın Projeleri Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<ProjectVM>>(null, true, "Çalışanın Projeleri Getirilemedi");
            }
        }
    }
}
