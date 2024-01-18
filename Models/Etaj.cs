namespace Gestionare_Camere_Hotel.Models
{
    public class Etaj
    {
        public int Id { get; set; }
        public int NumarEtaj { get; set; }

     
        public ICollection<Camere>? Camere { get; set; }
    }
}
