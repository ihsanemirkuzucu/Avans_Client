using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AvansProjeClient.BLL.Abstract;
using AvansProjeClient.Models.GeneralReturn;
using AvansProjeClient.Models.VM.AdvanceVMs;
using Microsoft.AspNetCore.Authorization;

namespace AvansProjeClient.UI.Controllers
{
    [Authorize]
    public class AdvanceController : Controller
    {
        private IAdvanceBLL _advanceBLL;

        public AdvanceController(IAdvanceBLL advanceBll )
        {
            _advanceBLL = advanceBll;
        }


        [HttpGet]
        public async Task<IActionResult> AddAdvance()
        {
            var data = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var result = await _advanceBLL.GetAllProjectsByWorkerIDAsync(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value));
            ViewData["projectList"] = result.Data;
            return View(new AdvanceAddVM());
        }

        [HttpPost]
        public async Task<IActionResult> AddAdvance(AdvanceAddVM advanceAddVM)
        {
            var token = HttpContext.Request.Cookies["token"];
            var result = await _advanceBLL.AdvanceAddAsync(advanceAddVM, token);
            if (!result.Success)
            {
                TempData["resultAdvance"] = result.Data;
                return RedirectToAction("AddAdvance");

            }
            TempData["resultAdvance"] = result.Data;
            return RedirectToAction("AddAdvance");
        }

        [HttpGet]
        public async Task<IActionResult> AdvanceDetail(int advanceID)
        {
            var token = HttpContext.Request.Cookies["token"];
            var result = await _advanceBLL.GetAdvanceDetailsAsync(advanceID, token);
            TempData["resultAdvanceDetail"] = result.Data;
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> WorkerAdvanceHistory()
        {
            var token = HttpContext.Request.Cookies["token"];
            var result = await _advanceBLL.GetWorkerAdvanceListAsync(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value), token);

            TempData["resultAdvanceList"] = result.Data;

            return View(new WorkerAdvanceListVM());
        }

        [HttpGet]
        public async Task<IActionResult> ResponseAdvanceApproveDetail(int advanceID)
        {
            GeneralReturnType<AdvanceApproveVM> result = null;

            var token = HttpContext.Request.Cookies["token"];
            if (User.FindFirst(ClaimTypes.Role)?.Value != "Ön Muhasebe")
            {
                result = await _advanceBLL.GetAdvanceApproveDetailsAsync(advanceID, token);
                TempData["advanceApproveDetail"] = result.Data;
                return View();
            }
            result = await _advanceBLL.GetAdvanceApproveDetailsAsync(advanceID, token);
            TempData["advanceApproveDetail"] = result.Data;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AdvanceApprove()
        {
            var token = HttpContext.Request.Cookies["token"];
            var result = await _advanceBLL.GetAdvanceApproveListByWorkerIDAsync(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value), token);
            TempData["resultApproveList"] = result.Data;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ApproveAdvance(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM)
        {
            var token = HttpContext.Request.Cookies["token"];
            var result = await _advanceBLL.ApproveAdvanceAsync(advanceApproveStatusUpdateVM, token);
            TempData["resultApprove"] = result.Data;
            if (!result.Success)
            {
                return RedirectToAction("ResponseAdvanceApproveDetail", new { advanceID = advanceApproveStatusUpdateVM.AdvanceID });
            }

            return RedirectToAction("AdvanceApprove");
        }

        [HttpPost]
        public async Task<IActionResult> DetermineAdvanceDate(AdvanceApproveStatusUpdateVM advanceApproveStatusUpdateVM)
        {
            var token = HttpContext.Request.Cookies["token"];

            var result = await _advanceBLL.DetermineAdvanceDateAsync(advanceApproveStatusUpdateVM, token);
            TempData["resultApprove"] = result.Data;
            if (!result.Success)
            {
                return RedirectToAction("ResponseAdvanceApproveDetail", new { advanceID = advanceApproveStatusUpdateVM.AdvanceID });
            }

            return RedirectToAction("AdvanceApprove");
        }

        [HttpGet]
        public async Task<IActionResult> AdvancePayment()
        {
            var token = HttpContext.Request.Cookies["token"];
            var result = await _advanceBLL.GetAdvancePaymentListAsync(token);
            TempData["resultAdvancePaynemt"] = result.Data;
            return View();
        }

    }
}
