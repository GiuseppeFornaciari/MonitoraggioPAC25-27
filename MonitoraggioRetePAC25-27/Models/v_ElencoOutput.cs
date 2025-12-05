using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models;

public partial class v_ElencoOutput
{
    public int IdOutput { get; set; }

    public int IdProgetto { get; set; }
    [Display(Name = "Priorità")]
    public string CodPriorita { get; set; } = null!;
    [Display(Name = "Obiettivo Rete")]
    public string ObiettivoRete { get; set; } = null!;
    [Display(Name = "Risultati attesi")]
    public string? RisultatiAttesi { get; set; }
    [Display(Name = "Tema")]
    public string CodTema { get; set; } = null!;
    [Display(Name = "Tipo output")]
    public string CodTipoOutput { get; set; } = null!;
    [Display(Name = "Codice Output")]
    public string CodOutputCompleto { get; set; } = null!;
    [Display(Name = "Output")]
    public string? OutputDescrizione { get; set; }
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
    [Display(Name = "Output allegati")]
    public string? OutputAllegato { get; set; }
    [Display(Name = "Output link")]
    public string? OutputLink { get; set; }
    [Display(Name = "Note sull'output del Responsabile Ente")]
    public string? NoteOutputResponsabileEnte { get; set; }
    [Display(Name = "Parere sull'output del Responsabile Ministero")]
    public int? ParereResponsabileMinistero { get; set; }
    [Display(Name = "Data parere sull'output del Responsabile Ministero")]
    public DateTime? ParereResponsabileMinisteroData { get; set; }
    [Display(Name = "Motivazione non conformità/parziale conformità")]
    public string? MotivazioneResponsabileMinistero { get; set; }
    [Display(Name = "Comunicazione output")]
    public bool Comunicazione { get; set; }
    [Display(Name = "Data comunicazione output")]
    public DateTime? ComunicazioneData { get; set; }
    [Display(Name = "Data ultimo aggiornamento output")]
    public DateTime? UltimoAggiornamento { get; set; }

}
