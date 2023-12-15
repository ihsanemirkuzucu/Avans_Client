using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.ApiService.AuthApiService;
using AvansProjeClient.Models.GeneralReturn;
using AvansProjeClient.Models.VM.AuthVMs;
using AvansProjeClient.Models.VM.TitleVMs;
using AvansProjeClient.Models.VM.UnitVMs;

namespace AvansProjeClient.BLL.Abstract
{
    public interface IAuthBLL
    {
        Task<GeneralReturnType<RequiredDataVM>> GetRequiredDataAsync();
        Task<GeneralReturnType<List<TitleVM>>> GetTitleAsync();
        Task<GeneralReturnType<List<UnitVM>>> GetUnitAsync();
    }
}
