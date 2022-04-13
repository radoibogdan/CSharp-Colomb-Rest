
using Colomb.Configurations.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Bridge between our classes and our actual database
namespace Colomb.Data
{
    public class DatabaseContext : IdentityDbContext<Compte>
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
            base.OnModelCreating(builder);
            // Fake data
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new EvenementConfiguration());
            builder.ApplyConfiguration(new CompteConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());

            builder.Entity<Compte>()
                .HasMany(c => c.EvenementsLiked)
                .WithMany(e => e.ComptesEvenementsLiked)
                .UsingEntity(j => j.HasData(
                    new { ComptesEvenementsLikedId = "1", EvenementsLikedEvenementId = 3 },
                    new { ComptesEvenementsLikedId = "2", EvenementsLikedEvenementId = 3 },
                    new { ComptesEvenementsLikedId = "2", EvenementsLikedEvenementId = 1 },
                    new { ComptesEvenementsLikedId = "3", EvenementsLikedEvenementId = 2 },
                    new { ComptesEvenementsLikedId = "3", EvenementsLikedEvenementId = 1 },
                    new { ComptesEvenementsLikedId = "3", EvenementsLikedEvenementId = 3 }
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
                   new { ComptesReviewsLikedId = "1", ReviewsLikedReviewId = 5 },
                   new { ComptesReviewsLikedId = "2", ReviewsLikedReviewId = 1 },
                   new { ComptesReviewsLikedId = "2", ReviewsLikedReviewId = 2 },
                   new { ComptesReviewsLikedId = "2", ReviewsLikedReviewId = 3 },
                   new { ComptesReviewsLikedId = "2", ReviewsLikedReviewId = 4 },
                   new { ComptesReviewsLikedId = "3", ReviewsLikedReviewId = 1 },
                   new { ComptesReviewsLikedId = "3", ReviewsLikedReviewId = 2 },
                   new { ComptesReviewsLikedId = "3", ReviewsLikedReviewId = 3 },
                   new { ComptesReviewsLikedId = "3", ReviewsLikedReviewId = 4 },
                   new { ComptesReviewsLikedId = "3", ReviewsLikedReviewId = 5 }
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
