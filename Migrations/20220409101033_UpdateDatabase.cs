using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colomb.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comptes",
                columns: table => new
                {
                    CompteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisibiliteReviews = table.Column<bool>(type: "bit", nullable: false),
                    estValide = table.Column<bool>(type: "bit", nullable: false),
                    NumeroSiret = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comptes", x => x.CompteId);
                });

            migrationBuilder.CreateTable(
                name: "Evenements",
                columns: table => new
                {
                    EvenementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureOuverture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureFermeture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombrePersMax = table.Column<int>(type: "int", nullable: false),
                    NombreLikes = table.Column<int>(type: "int", nullable: false),
                    NombreVues = table.Column<int>(type: "int", nullable: false),
                    EstSignale = table.Column<bool>(type: "bit", nullable: false),
                    EstSuspendu = table.Column<bool>(type: "bit", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    CompteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenements", x => x.EvenementId);
                    table.ForeignKey(
                        name: "FK_Evenements_Comptes_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Comptes",
                        principalColumn: "CompteId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CompteEvenement",
                columns: table => new
                {
                    ComptesEvenementsLikedCompteId = table.Column<int>(type: "int", nullable: false),
                    EvenementsLikedEvenementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompteEvenement", x => new { x.ComptesEvenementsLikedCompteId, x.EvenementsLikedEvenementId });
                    table.ForeignKey(
                        name: "FK_CompteEvenement_Comptes_ComptesEvenementsLikedCompteId",
                        column: x => x.ComptesEvenementsLikedCompteId,
                        principalTable: "Comptes",
                        principalColumn: "CompteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompteEvenement_Evenements_EvenementsLikedEvenementId",
                        column: x => x.EvenementsLikedEvenementId,
                        principalTable: "Evenements",
                        principalColumn: "EvenementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreEtoiles = table.Column<int>(type: "int", nullable: false),
                    NombreLikes = table.Column<int>(type: "int", nullable: false),
                    Contenu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstSignale = table.Column<bool>(type: "bit", nullable: false),
                    CompteId = table.Column<int>(type: "int", nullable: true),
                    EvenementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Comptes_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Comptes",
                        principalColumn: "CompteId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey( 
                        name: "FK_Reviews_Evenements_EvenementId",
                        column: x => x.EvenementId,
                        principalTable: "Evenements",
                        principalColumn: "EvenementId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CompteReview",
                columns: table => new
                {
                    ComptesReviewsLikedCompteId = table.Column<int>(type: "int", nullable: false),
                    ReviewsLikedReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompteReview", x => new { x.ComptesReviewsLikedCompteId, x.ReviewsLikedReviewId });
                    table.ForeignKey(
                        name: "FK_CompteReview_Comptes_ComptesReviewsLikedCompteId",
                        column: x => x.ComptesReviewsLikedCompteId,
                        principalTable: "Comptes",
                        principalColumn: "CompteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompteReview_Reviews_ReviewsLikedReviewId",
                        column: x => x.ReviewsLikedReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompteEvenement_EvenementsLikedEvenementId",
                table: "CompteEvenement",
                column: "EvenementsLikedEvenementId");

            migrationBuilder.CreateIndex(
                name: "IX_CompteReview_ReviewsLikedReviewId",
                table: "CompteReview",
                column: "ReviewsLikedReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Evenements_CompteId",
                table: "Evenements",
                column: "CompteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CompteId",
                table: "Reviews",
                column: "CompteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_EvenementId",
                table: "Reviews",
                column: "EvenementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompteEvenement");

            migrationBuilder.DropTable(
                name: "CompteReview");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Evenements");

            migrationBuilder.DropTable(
                name: "Comptes");
        }
    }
}
