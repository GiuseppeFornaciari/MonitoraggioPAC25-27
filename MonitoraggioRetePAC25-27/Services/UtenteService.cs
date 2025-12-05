using MonitoraggioRetePAC25_27.Data;

namespace MonitoraggioRetePAC25_27.Services
{
    public class UtenteService
    {
        //private readonly ApplicationDbContext _context;
        private readonly MonitoraggioRetePAC2527Context _context;

        public UtenteService(MonitoraggioRetePAC2527Context context)
        {
            _context = context;
        }

        public string GetNomeCompletoByEmail(string email)
        {
            var utente = _context.Utentis.FirstOrDefault(u => u.Email == email);
            return utente?.Utente ?? string.Empty;
        }
    }
}
