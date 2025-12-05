using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models;

public partial class Progetti
{
    public int idProgetto { get; set; }
    public int IdScheda { get; set; }
    [Required(ErrorMessage = "Codice progetto obbligatorio")]
    [StringLength(10, ErrorMessage = "Il codice progetto non può superare i 10 caratteri")]
    [Display(Name = "Codice progetto")]
    public string CodProgetto { get; set; } = null!;
    [Required(ErrorMessage = "Definizione progetto obbligatoria")]
    [StringLength(255, ErrorMessage = "La descrizione non può superare i 255 caratteri")]
    [Display(Name = "Progetto")]
    public string Progetto { get; set; } = null!;
    [Display(Name = "Informazioni inserite nel Progetto dal Responsabile Ente")]
    public bool CheckInserimentoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Data inserimento informazioni nel Progetto dal Responsabile Ente")]
    public DateTime? DataInserimentoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Informazioni inserite nel Progetto dal Responsabile Ministero")]
    public bool CheckInserimentoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Data inserimento informazioni nel Progetto dal Responsabile Ministero")]
    public DateTime? DataInserimentoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Note sul Progetto del Responsabile Ente")]
    public string? NoteProgettoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Note sul Progetto del Responsabile Ministero")]
    public string? NoteProgettoResponsabileProgettoMinistero { get; set; }

    public virtual Schede? IdSchedaNavigation { get; set; }

    public virtual ICollection<Output> Outputs { get; set; } = new List<Output>();

    public virtual ICollection<UtentiProgettoEnte> UtentiProgettoEntes { get; set; } = new List<UtentiProgettoEnte>();

    public virtual ICollection<UtentiProgettoMinistero> UtentiProgettoMinisteros { get; set; } = new List<UtentiProgettoMinistero>();
}
