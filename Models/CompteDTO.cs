using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Colomb.Data;

namespace Colomb.Models
{
    public class LoginCompteDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Votre mot de passe est limité entre {2} et {1} caractères", MinimumLength = 6)]
        public string Password { get; set; }
    }
    public class CompteDTO : LoginCompteDTO
    {
        public int Id { get; set; } // TKey in Identity User - inherited by compte
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DOB { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public bool VisibiliteReviews { get; set; }
        public bool estValide { get; set; }
        public string NumeroSiret { get; set; }
        public List<ReviewDTO> Reviews { get; set; }
        public List<EvenementDTO> EvenementsCrees { get; set; }
        public ICollection<EvenementDTO> EvenementsLiked { get; set; }
        public ICollection<ReviewDTO> ReviewsLiked { get; set; }
        public ICollection<string> Roles { get; set; }
    }

    public class RegisterCompteDTO : LoginCompteDTO
    {
        public ICollection<string> Roles { get; set; }
    }
}
