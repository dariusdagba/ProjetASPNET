﻿namespace AppTrans.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int CategorieId { get; set; }
    }
}
