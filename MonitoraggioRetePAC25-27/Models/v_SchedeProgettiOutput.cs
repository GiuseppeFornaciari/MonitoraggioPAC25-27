using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models;

public partial class v_SchedeProgettiOutput
{
    [Display(Name = "Codice scheda")]
    public string CodScheda { get; set; } = null!;
    [Display(Name = "Ente")]
    public string? Ente { get; set; }
    [Display(Name = "Titolo scheda")]
    public string Scheda { get; set; } = null!;
    [Display(Name = "Responsabile Scheda Ente")]
    public string ResponsabileScheda { get; set; } = null!;
    [Display(Name = "Responsabile Scheda Ente email")]
    public string ResponsabileSchedaEmail { get; set; } = null!;
    public int? IdProgetto { get; set; }
    [Display(Name = "Codice Progetto")]
    public string? CodProgetto { get; set; }
    [Display(Name = "Titolo Progetto")]
    public string? Progetto { get; set; }
    [Display(Name = "Responsabile Progetto Ministero")]
    public string? ResponsabiliProgettoMinistero { get; set; }
    [Display(Name = "Responsabile Progetto Ente")]
    public string? ResponsabiliProgettoEnte { get; set; }
    [Display(Name = "Responsabile Progetto Ente email")]
    public string? ResponsabiliProgettoEnteEmail { get; set; }
    [Display(Name = "Responsabile Progetto Ministero email")]
    public string? ResponsabiliProgettoMinisteroEmail { get; set; }
    public int? idOutput { get; set; }
    [Display(Name = "Priorità")]
    public string? CodPriorita { get; set; }
    [Display(Name = "Obiettivo Rete")]
    public string? ObiettivoRete { get; set; }
    [Display(Name = "Risultati attesi")]
    public string? RisultatiAttesi { get; set; }
    [Display(Name = "Tema")]
    public string? CodTema { get; set; }
    [Display(Name = "Descrizione Tema")]
    public string? Tema { get; set; }
    [Display(Name = "Tipo output")]
    public string? CodTipoOutput { get; set; }
    [Display(Name = "Output")]
    public string? OutputDescrizione { get; set; }
    [Display(Name = "Codice Output")]
    public string? CodOutputCompleto { get; set; }
    [Display(Name = "Output programmato")]
    public string? OutputProgrammato { get; set; }
    [Display(Name = "Output realizzato")]
    public string? OutputRealizzato { get; set; }
    [Display(Name = "Output non programmato")]
    public string? OutputNonProgrammato { get; set; }
    [Display(Name = "n. output programmato")]
    public int? NumOutputProgrammato { get; set; }
    [Display(Name = "n. output realizzato")]
    public int? NumOutputRealizzato { get; set; }
    [Display(Name = "n. output non programmato")]
    public int? NumOutputNonProgrammato { get; set; }
    [Display(Name = "'Output allegato")]
    public string? OutputAllegato { get; set; }
    [Display(Name = "Output link")]
    public string? OutputLink { get; set; }
    [Display(Name = "Informazioni inserite nel Progetto dal Responsabile Ente")]
    public bool? CheckInserimentoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Parere formulato sul Progetto dal Responsabile Minstero")]
    public bool? CheckInserimentoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Note sul Progetto del Responsabile Ente")]
    public string? NoteProgettoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Note sul Progetto del Responsabile Ministero")]
    public string? NoteProgettoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Data inserimento informazioni nel Progetto dal Responsabile Ente")]
    public DateTime? DataInserimentoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Data inserimento informazioni nel Progetto dal Responsabile Ministero")]
    public DateTime? DataInserimentoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Note sull'output del Responsabile Ente")]
    public string? NoteOutputResponsabileEnte { get; set; }
    [Display(Name = "Parere sull'output del Responsabile Ministero")]
    public int? ParereResponsabileMinistero { get; set; }
    [Display(Name = "Data parere sull'output del Responsabile Ministero")]
    public DateTime? ParereResponsabileMinisteroData { get; set; }
    [Display(Name = "Motivazione non conformità/parziale conformità")]
    public string? MotivazioneResponsabileMinistero { get; set; }
    [Display(Name = "Comunicazine output")]
    public bool? Comunicazione { get; set; }
    [Display(Name = "Data comunicazione output")]
    public DateTime? ComunicazioneData { get; set; }
    [Display(Name = "Data ultimo aggiornamento output")]
    public DateTime? UltimoAggiornamento { get; set; }

    [Display(Name = "Data monitoraggio")]
    public DateOnly DataMonitoraggio { get; set; }

}
