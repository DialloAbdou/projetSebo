using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SeboDomain.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Référence { get; set; } = string.Empty;
        public string Titre { get; set; } = string.Empty ;
        public string Editeur { get; set; } = string.Empty;
        public string Créateur { get; set; } = string.Empty;
        public bool Etat { get; set; }
        public decimal Prix { get; set; }
        public bool Etat_Reapro { get; set; }
        public int Seuil_mini { get; set; }
        public int Qte_stock { get; set; }
        public double? Pourcentag_promo { get; set; }
        public string? Photo { get; set; }
        public string? Description { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
