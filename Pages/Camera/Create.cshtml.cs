using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gestionare_Camere_Hotel.Data;
using Gestionare_Camere_Hotel.Models;

namespace Gestionare_Camere_Hotel.Pages.Camera
{
    public class CreateModel : PageModel
    {
        private readonly Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext _context;

        public CreateModel(Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AngajatiID"] = new SelectList(_context.Angajati, "Id", "Name");
        ViewData["EtajID"] = new SelectList(_context.Etaj, "Id", "NumarEtaj");
        ViewData["TipCameraID"] = new SelectList(_context.TipCamera, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Camere Camere { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Camere.Add(Camere);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
