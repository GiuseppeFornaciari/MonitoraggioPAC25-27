using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioPAC25_27.Models;

public partial class Output
{
    public int IdOutput { get; set; }
    [Display(Name = "Data ultimo aggiornamento output")]
    public DateTime UltimoAggiornamento { get; set; }
    public int IdProgetto { get; set; }
    [Display(Name = "Priorità")]
    [StringLength(2, ErrorMessage = "Priorità non può superare i 2 caratteri")]
    [Required(ErrorMessage = "Priorità obbligatoria")]
    public string CodPriorita { get; set; } = null!;
    [Display(Name = "Obiettivo Rete")]
    [StringLength(2, ErrorMessage = "Obiettivo rete non può superare i 2 caratteri")]
    [Required(ErrorMessage = "Obiettivo Rete obbligatoria")]
    public string ObiettivoRete { get; set; } = null!;
    [Display(Name = "Risultati attesi")]
    public string? RisultatiAttesi { get; set; }
    //[Display(Name = "Codice Tema")] //tabella lookup
    [StringLength(3, ErrorMessage = "Codice tema non può superare i 3 caratteri")]
    [Display(Name = "Tema")] 
    public string CodTema { get; set; } = null!;
    [Display(Name = "Tipo output")]
    [StringLength(3, ErrorMessage = "Codice tipo output non può superare i 3 caratteri")]
    public string CodTipoOutput { get; set; } = null!;
    [Display(Name = "Codice Output")]
    [StringLength(14, ErrorMessage = "Codice output completo non può superare i 14 caratteri")]
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
    [Range(1, 99, ErrorMessage = "Inserire un valore tra 1 e 99")]
    public int? NumOutputProgrammato { get; set; }
    [Display(Name = "n. output realizzato")]
    [Range(0, 99, ErrorMessage = "Inserire un valore tra 0 e 99")]
    public int? NumOutputRealizzato { get; set; }
    [Display(Name = "n. output non programmato")]
    [Range(0, 99, ErrorMessage = "Inserire un valore tra 0 e 99")]
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
    public virtual Temi? CodTemaNavigation { get; set; }
    public virtual TipiOutput? CodTipoOutputNavigation { get; set; } 
    public virtual Progetti? IdProgettoNavigation { get; set; }

}
