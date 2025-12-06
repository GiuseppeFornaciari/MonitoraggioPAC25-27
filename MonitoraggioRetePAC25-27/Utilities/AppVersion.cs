using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace MonitoraggioRetePAC25_27.Utilities
{
    public static class AppVersion
    {
        public static string Get()
        {
            var assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
            var version = assembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;

            if (string.IsNullOrWhiteSpace(version))
                return "?.?.?";

            // Rimuove tutto dopo '+' e dopo '-'
            //var clean = version.Split('+')[0];
            //var dashIndex = clean.IndexOf('-');
            //if (dashIndex >= 0)
            //    clean = clean.Substring(0, dashIndex);
            //
            //return clean;

            return version.Split('+')[0];

            
        }

        public static string GetWithCommitDate()
        {
            var assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
            var baseVersion = Get();
            string commitDate = "";

            try
            {
                var psi = new ProcessStartInfo("git", "log -1 --format=%cd --date=format:%d/%m/%Y")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                using var process = Process.Start(psi);
                commitDate = process?.StandardOutput.ReadToEnd().Trim();
            }
            catch
            {
                // in caso di errore (es. git non presente) commitDate resta vuoto
            }

            if (string.IsNullOrEmpty(commitDate))
            {
                // Usa la data dell'assembly come fallback (es. ambiente di produzione senza git)
                var assemblyPath = assembly.Location;
                if (!string.IsNullOrEmpty(assemblyPath) && File.Exists(assemblyPath))
                {
                    commitDate = File.GetLastWriteTime(assemblyPath).ToString("dd/MM/yyyy");
                }
            }

            return string.IsNullOrEmpty(commitDate)
                ? baseVersion
                : $"{baseVersion} del {commitDate}";
        }
    }
}
