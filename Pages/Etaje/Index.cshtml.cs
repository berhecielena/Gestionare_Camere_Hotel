using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gestionare_Camere_Hotel.Data;
using Gestionare_Camere_Hotel.Models;

namespace Gestionare_Camere_Hotel.Pages.Etaje
{
    public class IndexModel : PageModel
    {
        private readonly Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext _context;

        public IndexModel(Gestionare_Camere_Hotel.Data.Gestionare_Camere_HotelContext context)
        {
            _context = context;
        }

        public IList<Etaj> Etaj { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Etaj = await _context.Etaj.ToListAsync();
        }
    }
}
