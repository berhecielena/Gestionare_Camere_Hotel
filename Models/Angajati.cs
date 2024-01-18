namespace Gestionare_Camere_Hotel.Models
{
    public class Angajati
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumarTelefon { get; set; }
        public string Tura { get; set; }

        public ICollection<Camere>? Camere { get; set; }

    }
}
