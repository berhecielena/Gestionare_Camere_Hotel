﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gestionare_Camere_Hotel.Data;
using Gestionare_Camere_Hotel.Models;

namespace Gestionare_Camere_Hotel.Pages.Angajat
{
    public class EditModel : PageModel
    {
        private readonly Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext _context;

        public EditModel(Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext context)
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

            var angajati =  await _context.Angajati.FirstOrDefaultAsync(m => m.Id == id);
            if (angajati == null)
            {
                return NotFound();
            }
            Angajati = angajati;
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

            _context.Attach(Angajati).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AngajatiExists(Angajati.Id))
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

        private bool AngajatiExists(int id)
        {
            return _context.Angajati.Any(e => e.Id == id);
        }
    }
}
