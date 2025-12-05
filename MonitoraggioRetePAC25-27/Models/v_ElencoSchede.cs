using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioRetePAC25_27.Models;

public partial class v_ElencoSchede
{
    public int IdScheda { get; set; }
    [Display(Name ="Codice")]
    public string CodScheda { get; set; } = null!;

    public string Ente { get; set; } = null!;

    [Display(Name = "Responsabile Scheda Ente")]
    public string ResponsabileScheda { get; set; } = null!;
    [Display(Name = "Responsabile Scheda Ente email")]
    public string ResponsabileSchedaEmail { get; set; } = null!;
    [Display(Name = "Scheda")]
    public string Scheda { get; set; } = null!;
    [Display(Name = "Data")]
    public DateOnly DataMonitoraggio { get; set; }
}
