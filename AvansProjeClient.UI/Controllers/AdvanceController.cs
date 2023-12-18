using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AvansProjeClient.BLL.Abstract;
using AvansProjeClient.Models.VM.AdvanceVMs;

namespace AvansProjeClient.UI.Controllers
{
    public class AdvanceController : Controller
    {
        private IAdvanceBLL _advanceBLL;

        public AdvanceController(IAdvanceBLL advanceBll)
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
            var result = await _advanceBLL.AdvanceAddAsync(advanceAddVM);
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
            var result = await _advanceBLL.GetAdvanceDetailsAsync(advanceID);
            TempData["resultAdvanceDetail"] = result.Data;
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> WorkerAdvanceHistory()
        {
            var result = await _advanceBLL.GetWorkerAdvanceListAsync(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value));

            TempData["resultAdvanceList"] = result.Data;

            return View(new WorkerAdvanceListVM());
        }

        [HttpGet]
        public async Task<IActionResult> ResponseAdvanceApproveDetail(int advanceID)
        {
            var result = await _advanceBLL.GetAdvanceApproveDetailsAsync(advanceID);
            TempData["advanceApproveDetail"] = result.Data;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AdvanceApprove()
        {
            var result = await _advanceBLL.GetAdvanceApproveListByWorkerIDAsync(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value));
            TempData["resultApproveList"] = result.Data;
            return View();
        }

    }
}
