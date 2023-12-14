using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.GeneralReturn;
using AvansProjeClient.Models.VM.AuthVMs;

namespace AvansProjeClient.BLL.Abstract
{
    public interface IWorkerBLL
    {
        Task<GeneralReturnType<LoginVM>> LoginAsync(LoginVM loginVM);
        Task<GeneralReturnType<string>> RegisterAsync(RegisterVM registerVM);
    }
}
