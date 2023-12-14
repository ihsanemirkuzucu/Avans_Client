using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AvansProjeClient.BLL.Abstract;
using AvansProjeClient.Models.VM.AuthVMs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace AvansProjeClient.UI.Controllers
{
    public class AuthController : Controller
    {
        IWorkerBLL _workerBLL;

        public AuthController(IWorkerBLL workerBll)
        {
            _workerBLL = workerBll;
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(LoginVM loginVm)
        {
            var result = await _workerBLL.LoginAsync(loginVm);

            if (!result.Success)
            {
                ViewData["result"] = result.Message;
                return View(loginVm);
            }
            HttpContext.Response.Cookies.Append("token", result.Data.Token, new CookieOptions()
            {
                Expires = DateTimeOffset.Now.AddMinutes(20)
            });

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,result.Data.WorkerName),
                new Claim(ClaimTypes.Role,result.Data.TitleName)
            };
            var userId = new ClaimsIdentity(claims, "login");
            var userpri = new ClaimsPrincipal(userId);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userpri);
            return RedirectToAction("Index", "Home");

        }
    }
}
