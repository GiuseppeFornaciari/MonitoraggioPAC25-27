using System;
using System.Collections.Generic;

namespace MonitoraggioPAC25_27.Models;

public partial class UtentiRuoli
{
    public int IdUtenteRuolo { get; set; }

    public int IdUtente { get; set; }

    public string IdAspNetRoles { get; set; } = null!;

    public virtual AspNetRole IdAspNetRolesNavigation { get; set; } = null!;

    public virtual Utenti IdUtenteNavigation { get; set; } = null!;
}
