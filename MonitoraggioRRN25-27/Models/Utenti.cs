using System;
using System.Collections.Generic;

namespace MonitoraggioPAC25_27.Models;

public partial class Utenti
{
    public int idUtente { get; set; }

    public string Email { get; set; } = null!;

    public string Utente { get; set; } = null!;
    public string? idAspNetUser { get; set; }

    public virtual ICollection<UtentiProgettoEnte> UtentiProgettoEntes { get; set; } = new List<UtentiProgettoEnte>();

    public virtual ICollection<UtentiProgettoMinistero> UtentiProgettoMinisteros { get; set; } = new List<UtentiProgettoMinistero>();

    public virtual ICollection<UtentiRuoli> UtentiRuolis { get; set; } = new List<UtentiRuoli>();

    public virtual ICollection<UtentiSchedaEnte> UtentiSchedaEntes { get; set; } = new List<UtentiSchedaEnte>();

    public virtual AspNetUser? idAspNetUserNavigation { get; set; }
}
