using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gestionare_Camere_Hotel.Data;
using Gestionare_Camere_Hotel.Models;

namespace Gestionare_Camere_Hotel.Pages.Angajat
{
    public class DeleteModel : PageModel
    {
        private readonly Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext _context;

        public DeleteModel(Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Angajati Angajati { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var angajati = await _context.Angajati.FirstOrDefaultAsync(m => m.Id == id);

            if (angajati == null)
            {
                return NotFound();
            }
            else
            {
                Angajati = angajati;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var angajati = await _context.Angajati.FindAsync(id);
            if (angajati != null)
            {
                Angajati = angajati;
                _context.Angajati.Remove(Angajati);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
