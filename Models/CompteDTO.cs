using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Colomb.Data;

namespace Colomb.Models
{
    public class CompteDTO : CreateCompteDTO
    {
        public int CompteId { get; set; }
        public List<ReviewDTO> Reviews { get; set; }
        public List<EvenementDTO> EvenementsCrees { get; set; }
        public ICollection<EvenementDTO> EvenementsLiked { get; set; }
        public ICollection<ReviewDTO> ReviewsLiked { get; set; }
    }

    public class CreateCompteDTO
    {
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Votre login est trop long.")]
        public string Login { get; set; }
        public string Password { get; set; }
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
    }
}
