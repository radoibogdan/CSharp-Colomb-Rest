using Colomb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Models
{
    public class ReviewDTO : CreateReviewDTO
    {
        public int ReviewId { get; set; }
        public ICollection<CompteDTO> ComptesReviewsLiked { get; set; }
        public CompteDTO Compte { get; set; }
        public EvenementDTO Evenement { get; set; }
    }

    public class CreateReviewDTO
    {
        public DateTime Date { get; set; }
        [Required]
        [Range(1, 5)]
        public int NombreEtoiles { get; set; }
        public int NombreLikes { get; set; }
        public string Contenu { get; set; }
        public bool EstSignale { get; set; }
        public int? CompteId { get; set; }
        public int? EvenementId { get; set; }
    }
}
