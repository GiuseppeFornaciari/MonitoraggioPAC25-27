using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MonitoraggioRetePAC25_27.Data;
using MonitoraggioRetePAC25_27.Models;

namespace MonitoraggioRetePAC25_27
{
    public class IndexModel : PageModel
    {
        private readonly MonitoraggioRetePAC25_27.Data.MonitoraggioRetePAC2527Context _context;

        public IndexModel(MonitoraggioRetePAC25_27.Data.MonitoraggioRetePAC2527Context context)
        {
            _context = context;
        }

        public IList<Schede> Schede { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Schede = await _context.Schedes
                .Include(s => s.CodEnteNavigation)
                .Include(s => s.DataMonitoraggioNavigation).ToListAsync();
        }
    }
}
