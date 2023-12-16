using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.ApiService.WorkerAPIService;
using AvansProjeClient.BLL.Abstract;
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
                    return new GeneralReturnType<LoginVM>(null, false, "Email veya Password Doğru Doldurulamadı");
                }
                if (!MyExtensionMethods.IsEmailValid(loginVM.WorkerEmail))
                {
                    return new GeneralReturnType<LoginVM>(null, false, "Email doğru formatta girilmedi");
                }
                var result = await _workerService.LoginAsync(loginVM);
                if (result == null)
                {
                    throw new Exception();
                }
                return new GeneralReturnType<LoginVM>(result, true, "Giriş Başarılı");
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
                    return new GeneralReturnType<string>(null, false, "Email veya Password Doğru Doldurulamadı");
                }
                if (!MyExtensionMethods.IsEmailValid(registerVM.WorkerEmail))
                {
                    return new GeneralReturnType<string>(null, false, "Email doğru formatta girilmedi");
                }

                if (registerVM.Password != registerVM.PasswordConfirm)
                {
                    return new GeneralReturnType<string>(null, false, "Şifre Doğrulanamadı");
                }
                var result = await _workerService.RegisterAsync(registerVM);
                if (result == null)
                {
                    throw new Exception();
                }
                return new GeneralReturnType<string>(null, true, "Başarılı Kayıt");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<string>(null, false, ex.Message);
            }
        }

    }
}



       
