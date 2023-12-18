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
        Task<GeneralReturnType<List<AdvanceApproveListVM>>> GetAdvanceApproveListByWorkerIDAsync(int workerID);
        Task<GeneralReturnType<List<WorkerAdvanceListVM>>> GetWorkerAdvanceListAsync(int workerID);
        Task<GeneralReturnType<AdvanceDetailsVM>> GetAdvanceDetailsAsync(int advanceID);
        Task<GeneralReturnType<AdvanceApproveVM>> GetAdvanceApproveDetailsAsync(int advanceID);
        Task<GeneralReturnType<string>> AdvanceAddAsync(AdvanceAddVM advanceAddVM);
        Task<GeneralReturnType<List<ProjectVM>>> GetAllProjectAsync();
        Task<GeneralReturnType<List<ProjectVM>>> GetAllProjectsByWorkerIDAsync(int id);
    }
}
