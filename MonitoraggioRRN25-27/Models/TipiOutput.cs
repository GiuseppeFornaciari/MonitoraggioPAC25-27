using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioPAC25_27.Models;

public partial class TipiOutput
{
    public string CodTipoOutput { get; set; } = null!;

    public string? CodReg8082013 { get; set; }
    [Display(Name = "Tipo output")]
    public string TipoOutput { get; set; } = null!;

    public virtual ICollection<Output> Outputs { get; set; } = new List<Output>();
}
