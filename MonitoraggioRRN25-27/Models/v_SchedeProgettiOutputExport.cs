using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioPAC25_27.Models;

public partial class v_SchedeProgettiOutputExport
{
    /*Per esportare od escludere interire o togliere la voce DISPLAY */
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
    [Display(Name = "Priorità")]
    public string? CodPriorita { get; set; }
    [Display(Name = "Obiettivo Rete")]
    public string? ObiettivoRete { get; set; }
    [Display(Name = "Risultati attesi")]
    public string? RisultatiAttesi { get; set; }
    [Display(Name = "Tema ")]
    public string? CodTema { get; set; }
    [Display(Name = "Descrizione Tema")]
    public string? Tema { get; set; }
    [Display(Name = "Tipo output")]
    public string? CodTipoOutput { get; set; }
    [Display(Name = "Descrizione output")]
    public string? OutputDescrizione { get; set; }
    [Display(Name = "Output comunicazione")]
    public bool? Comunicazione { get; set; }
    [Display(Name = "Codice output")]
    public string? CodOutputCompleto { get; set; }
    [Display(Name = "Output programmato")]
    public string? OutputProgrammato { get; set; }
    [Display(Name = "Output realizzato")]
    public string? OutputRealizzato { get; set; }
    [Display(Name = "n. output programmato")]
    public int? NumOutputProgrammato { get; set; }
    [Display(Name = "n. output realizzato")]
    public int? NumOutputRealizzato { get; set; }
    [Display(Name = "Output allegati")]
    public string? OutputAllegato { get; set; }
    [Display(Name = "Output link")]
    public string? OutputLink { get; set; }
    [Display(Name = "n. output non programmato realizzato")]
    public int? NumOutputNonProgrammato { get; set; }
    [Display(Name = "Informaz. inserite dal Respons. Progetto Ente")]
    public bool? CheckInserimentoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Data ultimo aggiorn. output")]
    public DateTime? UltimoAggiornamento { get; set; }
    [Display(Name = "Note sull'output del Resp. Ente")]
    public string? NoteOutputResponsabileEnte { get; set; }
    [Display(Name = "Note sul Progetto del Resp. Ente")]
    public string? NoteProgettoResponsabileProgettoEnte { get; set; }
    [Display(Name = "Parere inserito sul Progetto del Resp. Ministero")]
    public bool? CheckInserimentoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Data parere sull'output del Resp. Ministero")]
    public DateTime? ParereResponsabileMinisteroData { get; set; }
    [Display(Name = "Parere sull'output del Resp. Ministero")]
    public string? ParereResponsabileMinistero { get; set; }
    [Display(Name = "Note sul Progetto del Resp. Ministero")]
    public string? NoteProgettoResponsabileProgettoMinistero { get; set; }
    [Display(Name = "Motivazione non conformità/parziale conformità output del Resp. Ministero")]
    public string? MotivazioneResponsabileMinistero { get; set; }
    [Display(Name = "Data monitoraggio")]
    public DateOnly DataMonitoraggio { get; set; }


    //CAMPI ESCLUSI
    public int? idProgetto { get; set; }
    public int? idOutput { get; set; }
    //[Display(Name = "Output non programmato")]
    public string? OutputNonProgrammato { get; set; }
    //[Display(Name = "Data inserimento informaz. nel Progetto dal Resp. Ente")]
    public DateTime? DataInserimentoResponsabileProgettoEnte { get; set; }
    //[Display(Name = "Data parere sul Progetto dal Resp. Ministero")]
    public DateTime? DataInserimentoResponsabileProgettoMinistero { get; set; }
    //[Display(Name = "Data comunicazione output")]
    public DateTime? ComunicazioneData { get; set; }
}
