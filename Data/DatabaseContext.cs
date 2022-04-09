
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Compte>()
                .HasMany(c => c.EvenementsLiked)
                .WithMany(e => e.ComptesEvenementsLiked);
            builder.Entity<Evenement>()
                .HasOne(e => e.Compte)
                .WithMany(c => c.EvenementsCrees)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Compte>()
               .HasMany(c => c.ReviewsLiked)
               .WithMany(e => e.ComptesReviewsLiked);
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

        public DbSet<Review> Reviews { get; set; } // Reviews = the name that the db will use
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        /*public DbSet<CompteLikerEvenement> CompteLikerEvenements { get; set; }*/

    }
}
