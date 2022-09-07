using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppDETAug2022.Data;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages.BookingPages
{
    public class IndexModel : PageModel
    {
        private readonly WebAppDETAug2022.Data.WebAppDETAug2022Context _context;

        public IndexModel(WebAppDETAug2022.Data.WebAppDETAug2022Context context)
        {
            _context = context;
        }

        public IList<Bookings> Bookings { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Bookings != null)
            {
                Bookings = await _context.Bookings.ToListAsync();
            }
        }
    }
}
