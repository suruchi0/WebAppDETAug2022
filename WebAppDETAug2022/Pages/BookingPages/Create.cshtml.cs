using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppDETAug2022.Data;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages.BookingPages
{
    public class CreateModel : PageModel
    {
        private readonly WebAppDETAug2022.Data.WebAppDETAug2022Context _context;

        public CreateModel(WebAppDETAug2022.Data.WebAppDETAug2022Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bookings Bookings { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Bookings == null || Bookings == null)
            {
                return Page();
            }

            _context.Bookings.Add(Bookings);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
