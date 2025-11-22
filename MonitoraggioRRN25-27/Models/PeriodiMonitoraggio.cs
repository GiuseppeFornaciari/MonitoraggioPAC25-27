using System;
using System.Collections.Generic;

namespace MonitoraggioPAC25_27.Models;

public partial class PeriodiMonitoraggio
{
    public DateOnly DataMonitoraggio { get; set; }

    public bool attivo { get; set; }

    public virtual ICollection<Schede> Schedes { get; set; } = new List<Schede>();
}
