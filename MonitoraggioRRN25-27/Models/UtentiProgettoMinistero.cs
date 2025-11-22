using System;
using System.Collections.Generic;

namespace MonitoraggioPAC25_27.Models;

public partial class UtentiProgettoMinistero
{
    public int idUtenteProgettoMinistero { get; set; }

    public int idProgetto { get; set; }

    public int idUtente { get; set; }

    public virtual Progetti idProgettoNavigation { get; set; } = null!;

    public virtual Utenti idUtenteNavigation { get; set; } = null!;
}
