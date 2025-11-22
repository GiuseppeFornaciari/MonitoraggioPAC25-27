using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonitoraggioPAC25_27.Models;

public partial class Temi
{
    [Display(Name = "Tema")]
    public string CodTema { get; set; } = null!;

    public string? Tema { get; set; }

    public virtual ICollection<Output> Outputs { get; set; } = new List<Output>();
}
