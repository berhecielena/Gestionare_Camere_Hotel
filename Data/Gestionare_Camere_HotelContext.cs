using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gestionare_Camere_Hotel.Models;

namespace Gestionare_Camere_Hotel.Data
{
    public class Gestionare_Camere_HotelContext : DbContext
    {
        public Gestionare_Camere_HotelContext (DbContextOptions<Gestionare_Camere_HotelContext> options)
            : base(options)
        {
        }

        public DbSet<Gestionare_Camere_Hotel.Models.Angajati> Angajati { get; set; } = default!;
        public DbSet<Gestionare_Camere_Hotel.Models.Camere> Camere { get; set; } = default!;
        public DbSet<Gestionare_Camere_Hotel.Models.TipCamera> TipCamera { get; set; } = default!;
        public DbSet<Gestionare_Camere_Hotel.Models.Etaj> Etaj { get; set; } = default!;
    }
}
