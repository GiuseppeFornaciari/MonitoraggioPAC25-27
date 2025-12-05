using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models;

public partial class v_ElencoProgetti
{
    public int IdProgetto { get; set; }

    public int IdScheda { get; set; }
    [Display(Name = "Codice")]
    public string CodProgetto { get; set; } = null!;
    [Display(Name = "Progetto")]
    public string Progetto { get; set; } = null!;
    [Display(Name = "Responsabile ente")]
    public string? ResponsabiliProgettoEnteEmail { get; set; }
    public string? ResponsabiliProgettoEnte { get; set; }
    [Display(Name = "Responsabile ministero")]
    public string? ResponsabiliProgettoMinistero { get; set; }
    public string? ResponsabiliProgettoMinisteroEmail { get; set; }
    [Display(Name = "Informazioni inserite nel Progetto dal Responsabile Ente")]
    public bool CheckInserimentoResponsabileProgettoEnte { get; set; }
    public bool CheckInserimentoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Data inserimento informazioni nel Progetto dal Responsabile Ente")]
    public DateTime? DataInserimentoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Data inserimento informazioni nel Progetto dal Responsabile Ministero")]
    public DateTime? DataInserimentoResponsabileProgettoMinistero { get; set; }

}
