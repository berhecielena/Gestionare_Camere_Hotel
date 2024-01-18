using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gestionare_Camere_Hotel.Data;
using Gestionare_Camere_Hotel.Models;

namespace Gestionare_Camere_Hotel.Pages.Camera
{
    public class EditModel : PageModel
    {
        private readonly Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext _context;

        public EditModel(Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Camere Camere { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camere =  await _context.Camere.FirstOrDefaultAsync(m => m.Id == id);
            if (camere == null)
            {
                return NotFound();
            }
            Camere = camere;
            ViewData["AngajatiID"] = new SelectList(_context.Angajati, "Id", "Name");
            ViewData["EtajID"] = new SelectList(_context.Etaj, "Id", "NumarEtaj");
            ViewData["TipCameraID"] = new SelectList(_context.TipCamera, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Camere).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CamereExists(Camere.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CamereExists(int id)
        {
            return _context.Camere.Any(e => e.Id == id);
        }
    }
}
