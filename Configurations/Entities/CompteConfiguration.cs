using Colomb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Configurations.Entities
{
    public class CompteConfiguration : IEntityTypeConfiguration<Compte>
    {
        public void Configure(EntityTypeBuilder<Compte> builder)
        {
            builder.HasData(
                new Compte
                {
                    Id = "1",
                    Email = "bogdan@gmail.com",
                    UserName = "bogdan",
                    PasswordHash = "bogdan",
                    Nom = "Radoi",
                    Prenom = "Bogdan",
                    Adresse = "40 rue de Compte",
                    DOB = new DateTime(1988, 12, 10, 0, 0, 0),
                    Photo = "chemin/photo_compte_profil",
                    Description = "Description",
                    Role = "ROLE_USER",
                    VisibiliteReviews = true,
                    estValide = true,
                    NumeroSiret = null
                },
                new Compte
                {
                    Id = "2",
                    Email = "wally@gmail.com",
                    UserName = "wally",
                    PasswordHash = "wally",
                    Nom = "Cisse",
                    Prenom = "Wally",
                    Adresse = "40 rue de Paris",
                    DOB = new DateTime(1992, 6, 12, 0, 0, 0),
                    Photo = "dossier/photo",
                    Description = "Description",
                    Role = "ROLE_USER",
                    VisibiliteReviews = true,
                    estValide = true,
                    NumeroSiret = null
                },
                new Compte
                {
                    Id = "3",
                    Email = "daria@gmail.com",
                    UserName = "daria",
                    PasswordHash = "Daria",
                    Nom = "Rychkova",
                    Prenom = "daria",
                    Adresse = "40 rue de Paris",
                    DOB = new DateTime(1990, 5, 20, 0, 0, 0),
                    Photo = "dossier/photo",
                    Description = "Description",
                    Role = "ROLE_USER",
                    VisibiliteReviews = true,
                    estValide = true,
                    NumeroSiret = null
                }
            );
        }
    }
}
