using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models;

public partial class Schede
{
    public int IdScheda { get; set; }
    [Required(ErrorMessage = "Codice scheda obbligatorio")]
    [StringLength(10, ErrorMessage = "Il codice scheda non può superare i 10 caratteri")]
    [Display(Name = "Codice scheda")]

    public string CodScheda { get; set; } = null!;
    [Display(Name = "Ente")]
    public int CodEnte { get; set; }
    [Required(ErrorMessage = "Definizione scheda obbligatoria")]
    [StringLength(255, ErrorMessage = "La descrizione non può superare i 255 caratteri")]
    [Display(Name = "Scheda")]

    public string Scheda { get; set; } = null!;

    [Display(Name = "Data monitoraggio")]
    public DateOnly DataMonitoraggio { get; set; }

    public virtual Enti? CodEnteNavigation { get; set; }

    public virtual PeriodiMonitoraggio? DataMonitoraggioNavigation { get; set; }

    public virtual ICollection<Progetti> Progettis { get; set; } = new List<Progetti>();

    public virtual ICollection<UtentiSchedaEnte> UtentiSchedaEntes { get; set; } = new List<UtentiSchedaEnte>();
}