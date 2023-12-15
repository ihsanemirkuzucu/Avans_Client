using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.ApiService.AuthApiService;
using AvansProjeClient.BLL.Abstract;
using AvansProjeClient.Models.GeneralReturn;
using AvansProjeClient.Models.VM.AuthVMs;
using AvansProjeClient.Models.VM.TitleVMs;
using AvansProjeClient.Models.VM.UnitVMs;

namespace AvansProjeClient.BLL.Concrete
{
    public class AuthBLL :IAuthBLL
    {
        private AuthService _api;

        public AuthBLL(AuthService api)
        {
            _api = api;
        }

        public async Task<GeneralReturnType<RequiredDataVM>> GetRequiredDataAsync()
        {
            try
            {
                var result = await _api.GetRequiredDataAsync();
                if (result == null)
                {
                    throw new Exception("Error");
                }
                return new GeneralReturnType<RequiredDataVM>(result, true, "Success");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<RequiredDataVM>(null, false, ex.Message);
            }
        }

        public async Task<GeneralReturnType<List<TitleVM>>> GetTitleAsync()
        {
            try
            {
                var result = await _api.GetTitleAsync();
                if (result == null)
                {
                    throw new Exception("Error");
                }
                return new GeneralReturnType<List<TitleVM>>(result, true, "Success");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<TitleVM>>(null, false, ex.Message);
            }
        }

        public async Task<GeneralReturnType<List<UnitVM>>> GetUnitAsync()
        {
            try
            {
                var result = await _api.GetUnitAsync();
                if (result == null)
                {
                    throw new Exception("Error");
                }
                return new GeneralReturnType<List<UnitVM>>(result, true, "Success");
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<UnitVM>>(null, false, ex.Message);
            }
        }
    }
}
