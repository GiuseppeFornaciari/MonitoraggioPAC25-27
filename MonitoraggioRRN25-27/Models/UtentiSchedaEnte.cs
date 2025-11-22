using System;
using System.Collections.Generic;

namespace MonitoraggioPAC25_27.Models;

public partial class UtentiSchedaEnte
{
    public int idUtenteScheda { get; set; }

    public int idScheda { get; set; }

    public int idUtente { get; set; }

    public virtual Schede idSchedaNavigation { get; set; } = null!;

    public virtual Utenti idUtenteNavigation { get; set; } = null!;
}
