namespace RestaurantApp1.Models
{
    public class Plat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }

        public string Categorie { get; set; }
    }
}
