using System.Security.Policy;

namespace Gestionare_Camere_Hotel.Models
{
    public class Camere
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? AngajatiID { get; set; }
        public Angajati? Angajat { get; set; }


        public int? EtajID { get; set; }
        public Etaj? Etaj { get; set; }


        public int? TipCameraID { get; set; }
        public TipCamera? TipCamera { get; set; }


    }
}
