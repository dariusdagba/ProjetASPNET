﻿namespace Journalapp.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Titre { get; set; }

        public string Contenu { get; set; }

        public DateTime DatePublication { get; set; }
        public string Auteur { get; set; }
    }
}
