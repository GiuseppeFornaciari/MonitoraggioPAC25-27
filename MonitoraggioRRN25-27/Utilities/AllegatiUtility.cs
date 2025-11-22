using MonitoraggioPAC25_27.Models;
using Microsoft.Extensions.Options;

namespace MonitoraggioPAC25_27.Utilities
{
    public class AllegatiUtility
    {
        private readonly string _percorsoBase;

        public AllegatiUtility(IConfiguration configuration)
        {
            _percorsoBase = configuration["Allegati:PercorsoBase"];

            if (string.IsNullOrWhiteSpace(_percorsoBase))
            {
                throw new InvalidOperationException("Percorso base degli allegati non configurato.");
            }
        }

        public string GetAllegatiPath(Output output)
        {
            if (output == null || output.IdProgettoNavigation?.IdSchedaNavigation == null)
            {
                throw new ArgumentNullException(nameof(output), "Output o dati di navigazione mancanti.");
            }

            var dataMonitoraggio = output.IdProgettoNavigation.IdSchedaNavigation.DataMonitoraggio;
            string dataFolder = dataMonitoraggio.ToString("yyyyMMdd");

            string path = Path.Combine(_percorsoBase, dataFolder, output.CodOutputCompleto);

            Directory.CreateDirectory(path);
            return path;
        }
    }
}
