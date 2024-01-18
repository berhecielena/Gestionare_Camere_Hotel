namespace Gestionare_Camere_Hotel.Models
{
    public class TipCamera
    {
        public int Id { get; set; }
        public string Name { get; set; }

   

        public ICollection<Camere>? Camere { get; set; }
    }
}
