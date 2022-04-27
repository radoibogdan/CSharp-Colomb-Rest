using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Data
{
    public class Review
    {
        public int ReviewId { get; set; }
        public DateTime Date { get; set; }
        public int NombreEtoiles { get; set; }
        public int NombreLikes { get; set; }
        public string Contenu { get; set; }
        public bool EstSignale { get; set; }
        public string? CompteId { get; set; } // ManyToOne Compte/Review // ManyToOne Compte/Evenement
        public Compte Compte { get; set; } 
        public int? EvenementId { get; set; } // ManyToOne Review/Evenement
        public Evenement Evenement { get; set; }
        public ICollection<Compte> ComptesReviewsLiked { get; set; } // ManyToMany Review/Comptes
    }
}
