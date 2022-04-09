using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colomb.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comptes",
                columns: new[] { "CompteId", "Adresse", "DOB", "Description", "Email", "Login", "Nom", "NumeroSiret", "Password", "Photo", "Prenom", "Role", "VisibiliteReviews", "estValide" },
                values: new object[] { 1, "40 rue de Compte", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", "bogdan@gmail.com", "bogdan", "Radoi", null, "bogdan", "chemin/photo_compte_profil", "Bogdan", "ROLE_USER", true, true });

            migrationBuilder.InsertData(
                table: "Comptes",
                columns: new[] { "CompteId", "Adresse", "DOB", "Description", "Email", "Login", "Nom", "NumeroSiret", "Password", "Photo", "Prenom", "Role", "VisibiliteReviews", "estValide" },
                values: new object[] { 2, "40 rue de Paris", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", "wally@gmail.com", "wally", "Cisse", null, "wally", "dossier/photo", "Wally", "ROLE_USER", true, true });

            migrationBuilder.InsertData(
                table: "Comptes",
                columns: new[] { "CompteId", "Adresse", "DOB", "Description", "Email", "Login", "Nom", "NumeroSiret", "Password", "Photo", "Prenom", "Role", "VisibiliteReviews", "estValide" },
                values: new object[] { 3, "40 rue de Paris", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", "daria@gmail.com", "daria", "Rychkova", null, "Daria", "dossier/photo", "daria", "ROLE_USER", true, true });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "EvenementId", "Adresse", "Categorie", "CompteId", "Date", "Description", "EstSignale", "EstSuspendu", "HeureFermeture", "HeureOuverture", "Latitude", "Longitude", "Nom", "NombreLikes", "NombrePersMax", "NombreVues", "Photo", "Prix" },
                values: new object[] { 1, "40 rue de Evenement", "musee", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description evenement", false, false, new DateTime(2022, 12, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), 22.219999999999999, 40.219999999999999, "Evenement Comedie", 2, 50, 40, "chemin/photo_evenement", 40f });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "EvenementId", "Adresse", "Categorie", "CompteId", "Date", "Description", "EstSignale", "EstSuspendu", "HeureFermeture", "HeureOuverture", "Latitude", "Longitude", "Nom", "NombreLikes", "NombrePersMax", "NombreVues", "Photo", "Prix" },
                values: new object[] { 3, "40 rue de Evenement", "spectacle", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description evenement", false, false, new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), 122.22, 140.22, "Evenement Parc", 112, 250, 140, "chemin/photo_evenement", 146f });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "EvenementId", "Adresse", "Categorie", "CompteId", "Date", "Description", "EstSignale", "EstSuspendu", "HeureFermeture", "HeureOuverture", "Latitude", "Longitude", "Nom", "NombreLikes", "NombrePersMax", "NombreVues", "Photo", "Prix" },
                values: new object[] { 2, "40 rue de Evenement", "theatre", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description evenement", false, false, new DateTime(2022, 12, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), 11.220000000000001, 55.219999999999999, "Evenement dehors", 440, 20, 140, "chemin/photo_evenement", 300f });

            migrationBuilder.InsertData(
                table: "CompteEvenement",
                columns: new[] { "ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "CompteId", "Contenu", "Date", "EstSignale", "EvenementId", "NombreEtoiles", "NombreLikes" },
                values: new object[,]
                {
                    { 3, 1, "Bref, je reviendrai pas", new DateTime(2022, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 1, 0 },
                    { 1, 2, "Sympa mais pas plus, je veux veux un remboursement", new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 2, 2 },
                    { 4, 2, "Ingenieux et spectaculaire", new DateTime(2022, 5, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 3, 11 },
                    { 5, 1, "Moyen mais pas cher, je ne recommande pas", new DateTime(2022, 9, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 2, 22 },
                    { 2, 3, "Tres bien", new DateTime(2022, 3, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "CompteReview",
                columns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 3, 3 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 4 },
                    { 3, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 2, 2 },
                    { 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompteEvenement",
                keyColumns: new[] { "ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CompteEvenement",
                keyColumns: new[] { "ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CompteEvenement",
                keyColumns: new[] { "ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CompteEvenement",
                keyColumns: new[] { "ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CompteEvenement",
                keyColumns: new[] { "ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CompteEvenement",
                keyColumns: new[] { "ComptesEvenementsLikedCompteId", "EvenementsLikedEvenementId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CompteReview",
                keyColumns: new[] { "ComptesReviewsLikedCompteId", "ReviewsLikedReviewId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comptes",
                keyColumn: "CompteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comptes",
                keyColumn: "CompteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comptes",
                keyColumn: "CompteId",
                keyValue: 2);
        }
    }
}
