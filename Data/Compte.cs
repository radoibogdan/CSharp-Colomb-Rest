using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Data
{
    public class Compte: IdentityUser
    {   
        /*public int CompteId { get; set; }*/       // Id in IdentityUser
        /*public string Email { get; set; }*/       // Email in IdentityUser
        /*public string Login { get; set; }*/       // UserName in IdentityUser
        /*public string Password { get; set; }*/    // PasswordHash in IdentityUser
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DOB { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        /*public string Role { get; set; }*/
        public bool VisibiliteReviews { get; set; } // new in MCD
        public bool estValide { get; set; }         // new in MCD
        public string NumeroSiret { get; set; }
        public virtual List<Review> Reviews { get; set; }              // OneToMany Compte/Review - Get list of Reviews associated with this Compte
        public virtual List<Evenement> EvenementsCrees { get; set; }   // OneToMany Compte/Evenement Get list of Evenements created by this Compte
        public ICollection<Evenement> EvenementsLiked { get; set; }    // ManyToMany Evenement/Comptes
        public ICollection<Review> ReviewsLiked { get; set; }          // ManyToMany Review/Comptes
    }
}
