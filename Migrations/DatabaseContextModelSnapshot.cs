﻿// <auto-generated />
using System;
using Colomb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Colomb.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Colomb.Data.Compte", b =>
                {
                    b.Property<int>("CompteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroSiret")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VisibiliteReviews")
                        .HasColumnType("bit");

                    b.Property<bool>("estValide")
                        .HasColumnType("bit");

                    b.HasKey("CompteId");

                    b.ToTable("Comptes");

                    b.HasData(
                        new
                        {
                            CompteId = 1,
                            Adresse = "40 rue de Compte",
                            DOB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description",
                            Email = "bogdan@gmail.com",
                            Login = "bogdan",
                            Nom = "Radoi",
                            Password = "bogdan",
                            Photo = "chemin/photo_compte_profil",
                            Prenom = "Bogdan",
                            Role = "ROLE_USER",
                            VisibiliteReviews = true,
                            estValide = true
                        },
                        new
                        {
                            CompteId = 2,
                            Adresse = "40 rue de Paris",
                            DOB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description",
                            Email = "wally@gmail.com",
                            Login = "wally",
                            Nom = "Cisse",
                            Password = "wally",
                            Photo = "dossier/photo",
                            Prenom = "Wally",
                            Role = "ROLE_USER",
                            VisibiliteReviews = true,
                            estValide = true
                        },
                        new
                        {
                            CompteId = 3,
                            Adresse = "40 rue de Paris",
                            DOB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description",
                            Email = "daria@gmail.com",
                            Login = "daria",
                            Nom = "Rychkova",
                            Password = "Daria",
                            Photo = "dossier/photo",
                            Prenom = "daria",
                            Role = "ROLE_USER",
                            VisibiliteReviews = true,
                            estValide = true
                        });
                });

            modelBuilder.Entity("Colomb.Data.Evenement", b =>
                {
                    b.Property<int>("EvenementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstSignale")
                        .HasColumnType("bit");

                    b.Property<bool>("EstSuspendu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("HeureFermeture")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HeureOuverture")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreLikes")
                        .HasColumnType("int");

                    b.Property<int>("NombrePersMax")
                        .HasColumnType("int");

                    b.Property<int>("NombreVues")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Prix")
                        .HasColumnType("real");

                    b.HasKey("EvenementId");

                    b.HasIndex("CompteId");

                    b.ToTable("Evenements");

                    b.HasData(
                        new
                        {
                            EvenementId = 1,
                            Adresse = "40 rue de Evenement",
                            Categorie = "musee",
                            CompteId = 1,
                            Date = new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description evenement",
                            EstSignale = false,
                            EstSuspendu = false,
                            HeureFermeture = new DateTime(2022, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            HeureOuverture = new DateTime(2022, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 22.219999999999999,
                            Longitude = 40.219999999999999,
                            Nom = "Evenement Comedie",
                            NombreLikes = 2,
                            NombrePersMax = 50,
                            NombreVues = 40,
                            Photo = "chemin/photo_evenement",
                            Prix = 40f
                        },
                        new
                        {
                            EvenementId = 2,
                            Adresse = "40 rue de Evenement",
                            Categorie = "theatre",
                            CompteId = 2,
                            Date = new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description evenement",
                            EstSignale = false,
                            EstSuspendu = false,
                            HeureFermeture = new DateTime(2022, 6, 15, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            HeureOuverture = new DateTime(2022, 6, 15, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 11.220000000000001,
                            Longitude = 55.219999999999999,
                            Nom = "Evenement dehors",
                            NombreLikes = 440,
                            NombrePersMax = 20,
                            NombreVues = 140,
                            Photo = "chemin/photo_evenement",
                            Prix = 300f
                        },
                        new
                        {
                            EvenementId = 3,
                            Adresse = "40 rue de Evenement",
                            Categorie = "spectacle",
                            CompteId = 1,
                            Date = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Description evenement",
                            EstSignale = false,
                            EstSuspendu = false,
                            HeureFermeture = new DateTime(2022, 2, 10, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            HeureOuverture = new DateTime(2022, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 122.22,
                            Longitude = 140.22,
                            Nom = "Evenement Parc",
                            NombreLikes = 112,
                            NombrePersMax = 250,
                            NombreVues = 140,
                            Photo = "chemin/photo_evenement",
                            Prix = 146f
                        });
                });

            modelBuilder.Entity("Colomb.Data.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompteId")
                        .HasColumnType("int");

                    b.Property<string>("Contenu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstSignale")
                        .HasColumnType("bit");

                    b.Property<int?>("EvenementId")
                        .HasColumnType("int");

                    b.Property<int>("NombreEtoiles")
                        .HasColumnType("int");

                    b.Property<int>("NombreLikes")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("CompteId");

                    b.HasIndex("EvenementId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            CompteId = 2,
                            Contenu = "Sympa mais pas plus, je veux veux un remboursement",
                            Date = new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            EstSignale = true,
                            EvenementId = 3,
                            NombreEtoiles = 2,
                            NombreLikes = 2
                        },
                        new
                        {
                            ReviewId = 2,
                            CompteId = 3,
                            Contenu = "Tres bien",
                            Date = new DateTime(2022, 3, 14, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            EstSignale = false,
                            EvenementId = 2,
                            NombreEtoiles = 5,
                            NombreLikes = 1
                        },
                        new
                        {
                            ReviewId = 3,
                            CompteId = 1,
                            Contenu = "Bref, je reviendrai pas",
                            Date = new DateTime(2022, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            EstSignale = false,
                            EvenementId = 1,
                            NombreEtoiles = 1,
                            NombreLikes = 0
                        },
                        new
                        {
                            ReviewId = 4,
                            CompteId = 2,
                            Contenu = "Ingenieux et spectaculaire",
                            Date = new DateTime(2022, 5, 17, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            EstSignale = false,
                            EvenementId = 3,
                            NombreEtoiles = 3,
                            NombreLikes = 11
                        },
                        new
                        {
                            ReviewId = 5,
                            CompteId = 1,
                            Contenu = "Moyen mais pas cher, je ne recommande pas",
                            Date = new DateTime(2022, 9, 19, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            EstSignale = false,
                            EvenementId = 3,
                            NombreEtoiles = 2,
                            NombreLikes = 22
                        });
                });

            modelBuilder.Entity("CompteEvenement", b =>
                {
                    b.Property<int>("ComptesEvenementsLikedCompteId")
                        .HasColumnType("int");

                    b.Property<int>("EvenementsLikedEvenementId")
                        .HasColumnType("int");

                    b.HasKey("ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId");

                    b.HasIndex("EvenementsLikedEvenementId");

                    b.ToTable("CompteEvenement");

                    b.HasData(
                        new
                        {
                            ComptesEvenementsLikedCompteId = 1,
                            EvenementsLikedEvenementId = 3
                        },
                        new
                        {
                            ComptesEvenementsLikedCompteId = 2,
                            EvenementsLikedEvenementId = 3
                        },
                        new
                        {
                            ComptesEvenementsLikedCompteId = 2,
                            EvenementsLikedEvenementId = 1
                        },
                        new
                        {
                            ComptesEvenementsLikedCompteId = 3,
                            EvenementsLikedEvenementId = 2
                        },
                        new
                        {
                            ComptesEvenementsLikedCompteId = 3,
                            EvenementsLikedEvenementId = 1
                        },
                        new
                        {
                            ComptesEvenementsLikedCompteId = 3,
                            EvenementsLikedEvenementId = 3
                        });
                });

            modelBuilder.Entity("CompteReview", b =>
                {
                    b.Property<int>("ComptesReviewsLikedCompteId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewsLikedReviewId")
                        .HasColumnType("int");

                    b.HasKey("ComptesReviewsLikedCompteId", "ReviewsLikedReviewId");

                    b.HasIndex("ReviewsLikedReviewId");

                    b.ToTable("CompteReview");

                    b.HasData(
                        new
                        {
                            ComptesReviewsLikedCompteId = 1,
                            ReviewsLikedReviewId = 5
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 2,
                            ReviewsLikedReviewId = 1
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 2,
                            ReviewsLikedReviewId = 2
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 2,
                            ReviewsLikedReviewId = 3
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 2,
                            ReviewsLikedReviewId = 4
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 3,
                            ReviewsLikedReviewId = 1
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 3,
                            ReviewsLikedReviewId = 2
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 3,
                            ReviewsLikedReviewId = 3
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 3,
                            ReviewsLikedReviewId = 4
                        },
                        new
                        {
                            ComptesReviewsLikedCompteId = 3,
                            ReviewsLikedReviewId = 5
                        });
                });

            modelBuilder.Entity("Colomb.Data.Evenement", b =>
                {
                    b.HasOne("Colomb.Data.Compte", "Compte")
                        .WithMany("EvenementsCrees")
                        .HasForeignKey("CompteId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Compte");
                });

            modelBuilder.Entity("Colomb.Data.Review", b =>
                {
                    b.HasOne("Colomb.Data.Compte", "Compte")
                        .WithMany("Reviews")
                        .HasForeignKey("CompteId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Colomb.Data.Evenement", "Evenement")
                        .WithMany("Reviews")
                        .HasForeignKey("EvenementId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Compte");

                    b.Navigation("Evenement");
                });

            modelBuilder.Entity("CompteEvenement", b =>
                {
                    b.HasOne("Colomb.Data.Compte", null)
                        .WithMany()
                        .HasForeignKey("ComptesEvenementsLikedCompteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Colomb.Data.Evenement", null)
                        .WithMany()
                        .HasForeignKey("EvenementsLikedEvenementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompteReview", b =>
                {
                    b.HasOne("Colomb.Data.Compte", null)
                        .WithMany()
                        .HasForeignKey("ComptesReviewsLikedCompteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Colomb.Data.Review", null)
                        .WithMany()
                        .HasForeignKey("ReviewsLikedReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Colomb.Data.Compte", b =>
                {
                    b.Navigation("EvenementsCrees");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Colomb.Data.Evenement", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
