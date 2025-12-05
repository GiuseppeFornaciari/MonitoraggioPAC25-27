using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace MonitoraggioRetePAC25_27.Services // <-- sostituisci con il namespace del tuo progetto
{
    public static class UserSeeder
    {
        public static async Task SeedFromCsvAsync(IServiceProvider serviceProvider, string csvPath)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            if (!File.Exists(csvPath))
            {
                Console.WriteLine($"❌ File CSV non trovato: {csvPath}");
                return;
            }

            var lines = File.ReadAllLines(csvPath)
                .Skip(1) // salta intestazione
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Split(','))
                .ToList();

            Console.WriteLine($"📄 Importazione di {lines.Count} utenti da {csvPath}...");

            foreach (var parts in lines)
            {
                if (parts.Length < 3) continue;

                var userName = parts[0].Trim();
                var email = parts[1].Trim();
                var password = parts[2].Trim();

                if (await userManager.FindByNameAsync(userName) != null)
                {
                    Console.WriteLine($"⚠️ Utente {userName} già esistente — saltato.");
                    continue;
                }

                var user = new IdentityUser
                {
                    UserName = userName,
                    Email = email,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                    Console.WriteLine($"✅ Creato utente: {userName}");
                else
                    Console.WriteLine($"❌ Errore creando {userName}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
            }

            Console.WriteLine("✅ Importazione completata.");
        }
    }
}

