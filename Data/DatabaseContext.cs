
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Bridge between our classes and our actual database
namespace Colomb.Data
{
    public class DatabaseContext : DbContext
    {
        // Define Constructor
        public DatabaseContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Review> Reviews { get; set; } // Reviews = the name that the db will use
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        /*public DbSet<CompteLikerEvenement> CompteLikerEvenements { get; set; }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Fake data
            builder.Entity<Compte>().HasData(
                new Compte
                {
                    CompteId = 1,
                    Email = "bogdan@gmail.com",
                    Login = "bogdan",
                    Password = "bogdan",
                    Nom = "Radoi",
                    Prenom = "Bogdan",
                    Adresse = "40 rue de Compte",
                    DOB = new DateTime(10 / 12 / 1988),
                    Photo = "chemin/photo_compte_profil",
                    Description = "Description",
                    Role = "ROLE_USER",
                    VisibiliteReviews = true,
                    estValide = true,
                    NumeroSiret = null
                },
                new Compte
                {
                    CompteId = 2,
                    Email = "wally@gmail.com",
                    Login = "wally",
                    Password = "wally",
                    Nom = "Cisse",
                    Prenom = "Wally",
                    Adresse = "40 rue de Paris",
                    DOB = new DateTime(10 / 12 / 1988),
                    Photo = "dossier/photo",
                    Description = "Description",
                    Role = "ROLE_USER",
                    VisibiliteReviews = true,
                    estValide = true,
                    NumeroSiret = null
                },
                new Compte
                {
                    CompteId = 3,
                    Email = "daria@gmail.com",
                    Login = "daria",
                    Password = "Daria",
                    Nom = "Rychkova",
                    Prenom = "daria",
                    Adresse = "40 rue de Paris",
                    DOB = new DateTime(10 / 12 / 1988),
                    Photo = "dossier/photo",
                    Description = "Description",
                    Role = "ROLE_USER",
                    VisibiliteReviews = true,
                    estValide = true,
                    NumeroSiret = null
                }
            );
            builder.Entity<Evenement>().HasData(
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
                  Photo = "chemin/photo_evenement",
                  Description = "Description evenement",
                  NombrePersMax = 50,
                  NombreLikes = 2,
                  NombreVues = 40,
                  EstSignale = false,
                  EstSuspendu = false,
                  Longitude = 40.22,
                  Latitude = 22.22,
                  CompteId = 1
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
                  Photo = "chemin/photo_evenement",
                  Description = "Description evenement",
                  NombrePersMax = 20,
                  NombreLikes = 440,
                  NombreVues = 140,
                  EstSignale = false,
                  EstSuspendu = false,
                  Longitude = 55.22,
                  Latitude = 11.22,
                  CompteId = 2
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
                  Photo = "chemin/photo_evenement",
                  Description = "Description evenement",
                  NombrePersMax = 250,
                  NombreLikes = 112,
                  NombreVues = 140,
                  EstSignale = false,
                  EstSuspendu = false,
                  Longitude = 140.22,
                  Latitude = 122.22,
                  CompteId = 1
              }
            );
            builder.Entity<Review>().HasData(
              new Review
              {
                  ReviewId = 1,
                  Date = new DateTime(2022, 12, 31, 17, 0, 0),
                  NombreEtoiles = 2,
                  NombreLikes = 2,
                  Contenu = "Sympa mais pas plus, je veux veux un remboursement",
                  EstSignale = true,
                  CompteId = 2,
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
                  CompteId = 3,
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
                  CompteId = 1,
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
                  CompteId = 2,
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
                  CompteId = 1,
                  EvenementId = 3,
              }
           );

            builder.Entity<Compte>()
                .HasMany(c => c.EvenementsLiked)
                .WithMany(e => e.ComptesEvenementsLiked)
                .UsingEntity(j => j.HasData(
                    new { ComptesEvenementsLikedCompteId = 1, EvenementsLikedEvenementId = 3 },
                    new { ComptesEvenementsLikedCompteId = 2, EvenementsLikedEvenementId = 3 },
                    new { ComptesEvenementsLikedCompteId = 2, EvenementsLikedEvenementId = 1 },
                    new { ComptesEvenementsLikedCompteId = 3, EvenementsLikedEvenementId = 2 },
                    new { ComptesEvenementsLikedCompteId = 3, EvenementsLikedEvenementId = 1 },
                    new { ComptesEvenementsLikedCompteId = 3, EvenementsLikedEvenementId = 3 }
                ))
                ;

            builder.Entity<Evenement>()
                .HasOne(e => e.Compte)
                .WithMany(c => c.EvenementsCrees)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Compte>()
               .HasMany(c => c.ReviewsLiked)
               .WithMany(e => e.ComptesReviewsLiked)
               .UsingEntity(j => j.HasData(
                   new { ComptesReviewsLikedCompteId = 1, ReviewsLikedReviewId = 5 },
                   new { ComptesReviewsLikedCompteId = 2, ReviewsLikedReviewId = 1 },
                   new { ComptesReviewsLikedCompteId = 2, ReviewsLikedReviewId = 2 },
                   new { ComptesReviewsLikedCompteId = 2, ReviewsLikedReviewId = 3 },
                   new { ComptesReviewsLikedCompteId = 2, ReviewsLikedReviewId = 4 },
                   new { ComptesReviewsLikedCompteId = 3, ReviewsLikedReviewId = 1 },
                   new { ComptesReviewsLikedCompteId = 3, ReviewsLikedReviewId = 2 },
                   new { ComptesReviewsLikedCompteId = 3, ReviewsLikedReviewId = 3 },
                   new { ComptesReviewsLikedCompteId = 3, ReviewsLikedReviewId = 4 },
                   new { ComptesReviewsLikedCompteId = 3, ReviewsLikedReviewId = 5 }
                ))
               ;
            builder.Entity<Review>()
                .HasOne(r => r.Compte)
                .WithMany(c => c.Reviews)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Review>()
                .HasOne(r => r.Evenement)
                .WithMany(c => c.Reviews)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            

        }


    }
}
