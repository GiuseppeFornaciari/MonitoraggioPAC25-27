namespace MonitoraggioPAC25_27.Views.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using MonitoraggioPAC25_27.Services;
    using System.Security.Claims;

    public class LoginInfoViewComponent : ViewComponent
    {
        private readonly UtenteService _utenteService;

        public LoginInfoViewComponent(UtenteService utenteService)
        {
            _utenteService = utenteService;
        }

        public IViewComponentResult Invoke()
        {
            if (!User.Identity.IsAuthenticated)
                return Content(""); // oppure View(null)

            var email = User.Identity.Name;
            var nomeCompleto = _utenteService.GetNomeCompletoByEmail(email);

            return View("Default", nomeCompleto);
        }
    }

}
