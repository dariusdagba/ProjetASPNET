using Microsoft.EntityFrameworkCore;

namespace AtelierApp.Models
{
    public class Atelier
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
    }
}
