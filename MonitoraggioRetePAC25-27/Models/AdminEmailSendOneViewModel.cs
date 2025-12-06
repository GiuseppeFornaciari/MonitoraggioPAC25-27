using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models
{
    public class AdminEmailSendOneViewModel
    {
        // Form
        [Required(ErrorMessage = "Seleziona un destinatario registrato.")]
        [EmailAddress(ErrorMessage = "Inserire un indirizzo email valido.")]
        public string Destinatario { get; set; }
        [Required(ErrorMessage = "L'oggetto è obbligatorio.")]
        public string Oggetto { get; set; }
        [Required(ErrorMessage = "Il messaggio è obbligatorio.")]
        public string MessaggioHtml { get; set; }
        public List<SelectListItem> DestinatariDisponibili { get; set; } = new();

        // Log
        public List<LogEmailInvio> Log { get; set; } = new();
    }
}
