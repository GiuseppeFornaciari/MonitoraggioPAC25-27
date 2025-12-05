using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models
{
    public class SchedaProgettoDTO
    {
        public string? CodScheda { get; set; }
        [Display(Name = "Scheda")]
        public string? Scheda { get; set; }
        [Display(Name = "Responsabile Scheda Ente")]
        public string? ResponsabileScheda { get; set; }
        [Display(Name = "Responsabile Scheda Ente email")]
        public string? ResponsabileSchedaEmail { get; set; }
        public int? IdProgetto { get; set; }
        public string? CodProgetto { get; set; }
        [Display(Name = "Progetto")]
        public string? Progetto { get; set; }
        [Display(Name = "Responsabile Progetto Ministero")]
        public string? ResponsabiliProgettoMinistero { get; set; }
        [Display(Name = "Responsabile Progetto Ente email")]
        public string? ResponsabiliProgettoMinisteroEmail { get; set; }
        [Display(Name = "Responsabile Progetto Ente")]
        public string? ResponsabiliProgettoEnte { get; set; }
        [Display(Name = "Responsabile Progetto Ministero email")]
        public string? ResponsabiliProgettoEnteEmail { get; set; }
    }
}
