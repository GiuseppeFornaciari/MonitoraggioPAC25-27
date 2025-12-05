using Microsoft.AspNetCore.Mvc;
using MonitoraggioRetePAC25_27.Data;
using MonitoraggioRetePAC25_27.Models;
using MonitoraggioRetePAC25_27.Services;
using System.Diagnostics;

namespace MonitoraggioRetePAC25_27.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UtenteService _utenteService;

        public HomeController(ILogger<HomeController> logger, UtenteService utenteService)
        {
            _logger = logger;
            _utenteService = utenteService;
        }

        public IActionResult Index()
        {
            
            if (User.Identity != null && User.Identity.IsAuthenticated){

                var email = User.Identity?.Name;
                if (!string.IsNullOrEmpty(email))
                {
                    ViewBag.NomeCompleto = _utenteService.GetNomeCompletoByEmail(email);
                    return RedirectToAction("ElencoSchedeProgetto", "Schede");
                }
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
