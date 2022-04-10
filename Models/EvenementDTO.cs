using Colomb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Models
{
    public class EvenementDTO : CreateEvenementDTO
    {
        public int EvenementId { get; set; }
        public List<ReviewDTO> Reviews { get; set; }
        public ICollection<CompteDTO> ComptesEvenementsLiked { get; set; }
        public CompteDTO Compte { get; set; }
    }

    public class CreateEvenementDTO
    {
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "Le nom de l'événement est trop long.")]
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
        public int NombreVues { get; set; }
        public bool EstSignale { get; set; }
        public bool EstSuspendu { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int? CompteId { get; set; }
    }
}
