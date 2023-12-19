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

        public async Task<GeneralReturnType<List<AdvanceApproveListVM>>> GetAdvanceApproveListByWorkerIDAsync(int workerID, string token)
        {
            try
            {
                return new GeneralReturnType<List<AdvanceApproveListVM>>(await _api.AdvanceApproveListByWorkerIDAsync(workerID, token), true, "Onay Listesi Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdvanceApproveListVM>>(null, false, "Onay Listesi Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<List<WorkerAdvanceListVM>>> GetWorkerAdvanceListAsync(int workerID, string token)
        {
            try
            {
                return new GeneralReturnType<List<WorkerAdvanceListVM>>(await _api.WorkerAdvanceListAsync(workerID, token), true, "Çalışan Avanas Listesi Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<WorkerAdvanceListVM>>(null, true, "Çalışan Avanas Listesi Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<AdvanceDetailsVM>> GetAdvanceDetailsAsync(int advanceID, string token)
        {
            try
            {
                return new GeneralReturnType<AdvanceDetailsVM>(await _api.AdvanceDetailsAsync(advanceID, token), true, "Avans Detayları Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdvanceDetailsVM>(null, false, "Avans Detayları Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<AdvanceApproveVM>> GetAdvanceApproveDetailsAsync(int advanceID, string token)
        {
            try
            {
                return new GeneralReturnType<AdvanceApproveVM>(await _api.AdvanceApproveDetailsAsync(advanceID, token), true,"Avans Detayları Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdvanceApproveVM>(null, false, "Avans Detayları Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<string>> AdvanceAddAsync(AdvanceAddVM advanceAddVM, string token)
        {
            try
            {
                return new GeneralReturnType<string>(await _api.AdvanceAddAsync(advanceAddVM, token), true, "Avans Talebi Eklendi");
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


        public async Task<GeneralReturnType<List<AdvancePaymentVM>>> GetAdvancePaymentListAsync(string token)
        {
            try
            {
                return new GeneralReturnType<List<AdvancePaymentVM>>(await _api.GetAdvancePaymentListAsync(token), true, "Avans Ödeme Bilgileri Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdvancePaymentVM>>(null, false, "Avans Ödeme Bilgileri Getirilemedi");
            }
        }

        public async Task<GeneralReturnType<AdvanceApproveVM>> GetAdvancePaymentDetailsAsync(int advanceID, string token)
        {
            try
            {
                return new GeneralReturnType<AdvanceApproveVM>(await _api.AdvancePaymentDetailsAsync(advanceID, token), true, "Avans Ödeme Detayları Getirildi");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdvanceApproveVM>(null, false, "Avans Ödeme Detayları Getirilelemedi" +ex.Message);
            }
        }

        public async Task<GeneralReturnType<string>> ApproveAdvanceAsync(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM, string token)
        {
            try
            {
                if (advanceApproveStatusUpdateVM.ApprovedAmount <= 0)
                {
                    throw new Exception("Onaylanacak Tutar 0'dan Küçük Olamaz");
                }
                var result = await _api.ApproveAdvaceAsync(advanceApproveStatusUpdateVM, token);
                if (result != "Avans Onaylandı.")
                {
                    throw new Exception(result);
                }
                return new GeneralReturnType<string>(result, true, "Başarılı");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<string>(ex.Message, false, "Başarısız");
            }
        }

        public async Task<GeneralReturnType<string>> RejectAdvanceAsync(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM, string token)
        {
            try
            {

                var result = await _api.RejectAdvanceAsync(advanceApproveStatusUpdateVM, token);
                if (result != "Avans Reddedildi.")
                {
                    throw new Exception(result);
                }
                return new GeneralReturnType<string>(result, true, "Başarılı");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<string>(ex.Message, false, "Başarısız");
            }
        }

        public async Task<GeneralReturnType<string>> DetermineAdvanceDateAsync(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM, string token)
        {
            try
            {

                var result = await _api.DetermineAdvanceDateAsync(advanceApproveStatusUpdateVM, token);
                if (result != "Avans Tarihi Belirlendi.")
                {
                    throw new Exception(result);
                }
                return new GeneralReturnType<string>(result, true, "Başarılı");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<string>(ex.Message, false, "Başarısız");
            }
        }
    }
}
