using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.GeneralReturn;
using AvansProjeClient.Models.VM.AdvanceVMs;
using AvansProjeClient.Models.VM.ProjectVMs;

namespace AvansProjeClient.BLL.Abstract
{
    public interface IAdvanceBLL
    {
        Task<GeneralReturnType<List<AdvanceApproveListVM>>> GetAdvanceApproveListByWorkerIDAsync(int workerID, string token);
        Task<GeneralReturnType<List<WorkerAdvanceListVM>>> GetWorkerAdvanceListAsync(int workerID, string token);
        Task<GeneralReturnType<AdvanceDetailsVM>> GetAdvanceDetailsAsync(int advanceID, string token);
        Task<GeneralReturnType<AdvanceApproveVM>> GetAdvanceApproveDetailsAsync(int advanceID, string token);
        Task<GeneralReturnType<string>> AdvanceAddAsync(AdvanceAddVM advanceAddVM, string token);
        Task<GeneralReturnType<List<ProjectVM>>> GetAllProjectAsync();
        Task<GeneralReturnType<List<ProjectVM>>> GetAllProjectsByWorkerIDAsync(int id);

        Task<GeneralReturnType<List<AdvancePaymentVM>>> GetAdvancePaymentListAsync(string token);
        Task<GeneralReturnType<AdvanceApproveVM>> GetAdvancePaymentDetailsAsync(int advanceID, string token);
        Task<GeneralReturnType<string>> ApproveAdvanceAsync(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM, string token);
        Task<GeneralReturnType<string>> RejectAdvanceAsync(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM, string token);
        Task<GeneralReturnType<string>> DetermineAdvanceDateAsync(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM, string token);
    }
}
