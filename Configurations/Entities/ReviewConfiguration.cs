using Colomb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Configurations.Entities
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                 new Review
                 {
                     ReviewId = 1,
                     Date = new DateTime(2022, 12, 31, 17, 0, 0),
                     NombreEtoiles = 2,
                     NombreLikes = 2,
                     Contenu = "Sympa mais pas plus, je veux veux un remboursement",
                     EstSignale = true,
                     /*CompteId = 2,*/
                     EvenementId = 3,
                 },
                 new Review
                 {
                     ReviewId = 2,
                     Date = new DateTime(2022, 3, 14, 17, 0, 0),
                     NombreEtoiles = 5,
                     NombreLikes = 1,
                     Contenu = "Tres bien",
                     EstSignale = false,
                     /*CompteId = 3,*/
                     EvenementId = 2,
                 },
                 new Review
                 {
                     ReviewId = 3,
                     Date = new DateTime(2022, 2, 15, 17, 0, 0),
                     NombreEtoiles = 1,
                     NombreLikes = 0,
                     Contenu = "Bref, je reviendrai pas",
                     EstSignale = false,
                     /*CompteId = 1,*/
                     EvenementId = 1,
                 },
                 new Review
                 {
                     ReviewId = 4,
                     Date = new DateTime(2022, 5, 17, 17, 0, 0),
                     NombreEtoiles = 3,
                     NombreLikes = 11,
                     Contenu = "Ingenieux et spectaculaire",
                     EstSignale = false,
                     /*CompteId = 2,*/
                     EvenementId = 3,
                 },
                 new Review
                 {
                     ReviewId = 5,
                     Date = new DateTime(2022, 9, 19, 17, 0, 0),
                     NombreEtoiles = 2,
                     NombreLikes = 22,
                     Contenu = "Moyen mais pas cher, je ne recommande pas",
                     EstSignale = false,
                     /*CompteId = 1,*/
                     EvenementId = 3,
                 }
              );
        }
    }
}
