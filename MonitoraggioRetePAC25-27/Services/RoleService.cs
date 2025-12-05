namespace MonitoraggioRetePAC25_27.Services
{
    public class RoleService
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public RoleService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetRuolo()
        {
            var user = _httpContextAccessor.HttpContext?.User;
            string ruolo = "";

            if (user == null)
                return ruolo;

            if (user.IsInRole("administrator"))
            {
                ruolo = "administrator";
            }
            else if (user.IsInRole("responsabile presso ente"))
            {
                ruolo = "responsabile presso ente";
            }
            else if (user.IsInRole("responsabile scheda"))
            {
                ruolo = "responsabile scheda";
            }
            else if (user.IsInRole("referente ministero"))
            {
                ruolo = "referente ministero";
            }
            else if (user.IsInRole("segretariato"))
            {
                ruolo = "segretariato";
            }

            return ruolo;
        }
    }
}
