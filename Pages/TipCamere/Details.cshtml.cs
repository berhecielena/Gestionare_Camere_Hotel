﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gestionare_Camere_Hotel.Data;
using Gestionare_Camere_Hotel.Models;

namespace Gestionare_Camere_Hotel.Pages.TipCamere
{
    public class DetailsModel : PageModel
    {
        private readonly Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext _context;

        public DetailsModel(Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext context)
        {
            _context = context;
        }

        public TipCamera TipCamera { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipcamera = await _context.TipCamera.FirstOrDefaultAsync(m => m.Id == id);
            if (tipcamera == null)
            {
                return NotFound();
            }
            else
            {
                TipCamera = tipcamera;
            }
            return Page();
        }
    }
}
