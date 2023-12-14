using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.ApiService.WorkerAPIService;
using AvansProjeClient.BLL.Abstract;
using AvansProjeClient.BLL.ErrorMessages;
using AvansProjeClient.BLL.MyExtensions;
using AvansProjeClient.Models.GeneralReturn;
using AvansProjeClient.Models.VM.AuthVMs;

namespace AvansProjeClient.BLL.Concrete
{
    public class WorkerBLL : IWorkerBLL
    {
        private WorkerService _workerService;

        public WorkerBLL(WorkerService workerService)
        {
            _workerService = workerService;
        }

        public async Task<GeneralReturnType<LoginVM>> LoginAsync(LoginVM loginVM)
        {
            try
            {
                if (!MyExtensionMethods.TextControl(loginVM.WorkerEmail, loginVM.Password))
                {
                    return new GeneralReturnType<LoginVM>(null, false, Messages.LoginInputNullError);
                }
                if (!MyExtensionMethods.IsEmailValid(loginVM.WorkerEmail))
                {
                    return new GeneralReturnType<LoginVM>(null, false, Messages.MailFormatError);
                }
                var result = await _workerService.LoginAsync(loginVM);
                if (result == null)
                {
                    throw new Exception();
                }
                return new GeneralReturnType<LoginVM>(result, true, Messages.SuccessfullLogin);
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<LoginVM>(null, false, ex.Message);
            }
        }

        public async Task<GeneralReturnType<string>> RegisterAsync(RegisterVM registerVM)
        {
            try
            {
                if (!MyExtensionMethods.TextControl(registerVM.WorkerEmail, registerVM.Password, registerVM.PasswordConfirm))
                {
                    return new GeneralReturnType<string>(null, false, Messages.LoginInputNullError);
                }
                if (!MyExtensionMethods.IsEmailValid(registerVM.WorkerEmail))
                {
                    return new GeneralReturnType<string>(null, false, Messages.MailFormatError);
                }

                if (registerVM.Password != registerVM.PasswordConfirm)
                {
                    return new GeneralReturnType<string>(null, false, Messages.PasswordConfirmError);
                }
                var result = await _workerService.RegisterAsync(registerVM);
                if (result == null)
                {
                    throw new Exception();
                }
                return new GeneralReturnType<string>(null, true, Messages.UserRegisteredSuccess);
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<string>(null, false, ex.Message);
            }
        }

    }
}



       
