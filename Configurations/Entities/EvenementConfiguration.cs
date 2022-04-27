using Colomb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Configurations.Entities
{
    public class EvenementConfiguration : IEntityTypeConfiguration<Evenement>
    {
        public void Configure(EntityTypeBuilder<Evenement> builder)
        {
            builder.HasData(
              new Evenement
              {
                  EvenementId = 1,
                  Nom = "Evenement Comedie",
                  Date = new DateTime(2022, 5, 20, 0, 0, 0),
                  HeureOuverture = new DateTime(2022, 5, 20, 9, 0, 0),
                  HeureFermeture = new DateTime(2022, 5, 20, 18, 0, 0),
                  Prix = 40,
                  Adresse = "40 rue de Evenement",
                  Categorie = "musee",
                  Photo = "https://www.tours-evenements.com/sites/default/files/media/header_image/header-tours-evenements.jpg",
                  Description = "Description evenement",
                  NombrePersMax = 50,
                  NombreLikes = 2,
                  NombreVues = 40,
                  EstSignale = false,
                  EstSuspendu = false,
                  Longitude = 40.22,
                  Latitude = 22.22,
                  /*CompteId = 1*/
              },
              new Evenement
              {
                  EvenementId = 2,
                  Nom = "Evenement dehors",
                  Date = new DateTime(2022, 6, 15, 0, 0, 0),
                  HeureOuverture = new DateTime(2022, 6, 15, 9, 0, 0),
                  HeureFermeture = new DateTime(2022, 6, 15, 19, 0, 0),
                  Prix = 300,
                  Adresse = "40 rue de Evenement",
                  Categorie = "theatre",
                  Photo = "https://www.tours-evenements.com/sites/default/files/media/header_image/header-tours-evenements.jpg",
                  Description = "Description evenement",
                  NombrePersMax = 20,
                  NombreLikes = 440,
                  NombreVues = 140,
                  EstSignale = false,
                  EstSuspendu = false,
                  Longitude = 55.22,
                  Latitude = 11.22,
                  /*CompteId = 2*/
              },
              new Evenement
              {
                  EvenementId = 3,
                  Nom = "Evenement Parc",
                  Date = new DateTime(2022, 2, 10, 0, 0, 0),
                  HeureOuverture = new DateTime(2022, 2, 10, 10, 0, 0),
                  HeureFermeture = new DateTime(2022, 2, 10, 17, 0, 0),
                  Prix = 146,
                  Adresse = "40 rue de Evenement",
                  Categorie = "spectacle",
                  Photo = "https://www.tours-evenements.com/sites/default/files/media/header_image/header-tours-evenements.jpg",
                  Description = "Description evenement",
                  NombrePersMax = 250,
                  NombreLikes = 112,
                  NombreVues = 140,
                  EstSignale = true,
                  EstSuspendu = true,
                  Longitude = 140.22,
                  Latitude = 122.22,
                  /*CompteId = 1*/
              }
            );
        }
    }
}
