using System;
using System.Collections.Generic;

namespace MonitoraggioRetePAC25_27.Models;

public partial class Enti
{
    public int CodEnte { get; set; }

    public string DescrizioneEnte { get; set; } = null!;

    public virtual ICollection<Schede> Schedes { get; set; } = new List<Schede>();
}
