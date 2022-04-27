using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Data
{
    public class Evenement
    {
        public int EvenementId { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public DateTime HeureOuverture { get; set; }
        public DateTime HeureFermeture { get; set; }
        public float Prix { get; set; }
        public string Adresse { get; set; }
        public string Categorie { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public int NombrePersMax { get; set; }
        public int NombreLikes { get; set; }
        public int NombreVues { get; set; } // new in MCD
        public bool EstSignale { get; set; }
        public bool EstSuspendu { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        /* [ForeignKey(nameof(Compte))]*/
        public string? CompteId { get; set; }                      // OneToMany Compte/Evenement (evenement crées)
        public Compte Compte { get; set; }
        public List<Review> Reviews { get; set; }               // list of reviews associated with the Evenement
        public ICollection<Compte> ComptesEvenementsLiked { get; set; }   // ManyToMany Evenement/Comptes
    }
}
