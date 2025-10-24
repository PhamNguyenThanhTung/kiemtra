using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pntt_231220952.Models;

namespace pntt_231220952.Controllers
{
    public class pnttHomeController : Controller
    {
        private readonly ILogger<pnttHomeController> _logger;

        public pnttHomeController(ILogger<pnttHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult pnttIndex()
        {
            return View();
        }

        public IActionResult pnttPrivacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult pnttContact() { 
            return View();
        }
    }
}
