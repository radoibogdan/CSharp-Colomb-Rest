using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colomb.Migrations
{
    public partial class dbcreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisibiliteReviews = table.Column<bool>(type: "bit", nullable: false),
                    estValide = table.Column<bool>(type: "bit", nullable: false),
                    NumeroSiret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CompteId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenements", x => x.EvenementId);
                    table.ForeignKey(
                        name: "FK_Evenements_AspNetUsers_CompteId",
                        column: x => x.CompteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CompteEvenement",
                columns: table => new
                {
                    ComptesEvenementsLikedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EvenementsLikedEvenementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompteEvenement", x => new { x.ComptesEvenementsLikedId, x.EvenementsLikedEvenementId });
                    table.ForeignKey(
                        name: "FK_CompteEvenement_AspNetUsers_ComptesEvenementsLikedId",
                        column: x => x.ComptesEvenementsLikedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                    CompteId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EvenementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_CompteId",
                        column: x => x.CompteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                    ComptesReviewsLikedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReviewsLikedReviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompteReview", x => new { x.ComptesReviewsLikedId, x.ReviewsLikedReviewId });
                    table.ForeignKey(
                        name: "FK_CompteReview_AspNetUsers_ComptesReviewsLikedId",
                        column: x => x.ComptesReviewsLikedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompteReview_Reviews_ReviewsLikedReviewId",
                        column: x => x.ReviewsLikedReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e2fddbeb-5e73-4783-a08a-44b3972eba2a", "25e8a834-3d3a-42ec-b211-26236281d47c", "User", "USER" },
                    { "316e685c-5432-4da7-a019-84e2058a5408", "d9225178-dfc8-4c23-af1a-3b462ac3392b", "Administrator", "ADMINISTRATOR" },
                    { "f0b3ce1f-43d5-4466-b1f1-720c78b9eb78", "8cb1598f-3316-4c96-bc71-fb586114fb2c", "Entreprise", "ENTREPRISE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresse", "ConcurrencyStamp", "DOB", "Description", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nom", "NormalizedEmail", "NormalizedUserName", "NumeroSiret", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "Prenom", "SecurityStamp", "TwoFactorEnabled", "UserName", "VisibiliteReviews", "estValide" },
                values: new object[,]
                {
                    { "1", 0, "40 rue de Compte", "17dc49fa-de27-4811-a8e1-21c59705ed3e", new DateTime(1988, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", "bogdan@gmail.com", false, false, null, "Radoi", null, null, null, "bogdan", null, false, "chemin/photo_compte_profil", "Bogdan", "a6dc5597-414d-4330-ab8c-89896ac5c805", false, "bogdan", true, true },
                    { "2", 0, "40 rue de Paris", "3b572640-cee8-4bc0-9e41-5ee8b8b1400a", new DateTime(1992, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", "wally@gmail.com", false, false, null, "Cisse", null, null, null, "wally", null, false, "dossier/photo", "Wally", "41ac4aec-99b9-4b16-8a7c-1cb957d46dd4", false, "wally", true, true },
                    { "3", 0, "40 rue de Paris", "71dc99d2-a382-4c96-8871-342f5443ab75", new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", "daria@gmail.com", false, false, null, "Rychkova", null, null, null, "Daria", null, false, "dossier/photo", "daria", "028f1bb7-48dd-4175-bdcc-896862528849", false, "daria", true, true }
                });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "EvenementId", "Adresse", "Categorie", "CompteId", "Date", "Description", "EstSignale", "EstSuspendu", "HeureFermeture", "HeureOuverture", "Latitude", "Longitude", "Nom", "NombreLikes", "NombrePersMax", "NombreVues", "Photo", "Prix" },
                values: new object[,]
                {
                    { 1, "40 rue de Evenement", "musee", null, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description evenement", false, false, new DateTime(2022, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 22.219999999999999, 40.219999999999999, "Evenement Comedie", 2, 50, 40, "https://www.tours-evenements.com/sites/default/files/media/header_image/header-tours-evenements.jpg", 40f },
                    { 2, "40 rue de Evenement", "theatre", null, new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description evenement", false, false, new DateTime(2022, 6, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), 11.220000000000001, 55.219999999999999, "Evenement dehors", 440, 20, 140, "https://www.tours-evenements.com/sites/default/files/media/header_image/header-tours-evenements.jpg", 300f },
                    { 3, "40 rue de Evenement", "spectacle", null, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description evenement", true, true, new DateTime(2022, 2, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 122.22, 140.22, "Evenement Parc", 112, 250, 140, "https://www.tours-evenements.com/sites/default/files/media/header_image/header-tours-evenements.jpg", 146f }
                });

            migrationBuilder.InsertData(
                table: "CompteEvenement",
                columns: new[] { "ComptesEvenementsLikedId", "EvenementsLikedEvenementId" },
                values: new object[,]
                {
                    { "2", 1 },
                    { "3", 1 },
                    { "3", 2 },
                    { "1", 3 },
                    { "2", 3 },
                    { "3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "CompteId", "Contenu", "Date", "EstSignale", "EvenementId", "NombreEtoiles", "NombreLikes" },
                values: new object[,]
                {
                    { 3, null, "Bref, je reviendrai pas", new DateTime(2022, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 1, 1, 0 },
                    { 2, null, "Tres bien", new DateTime(2022, 3, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 2, 5, 1 },
                    { 1, null, "Sympa mais pas plus, je veux veux un remboursement", new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 2, 2 },
                    { 4, null, "Ingenieux et spectaculaire", new DateTime(2022, 5, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 3, 11 },
                    { 5, null, "Moyen mais pas cher, je ne recommande pas", new DateTime(2022, 9, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 2, 22 }
                });

            migrationBuilder.InsertData(
                table: "CompteReview",
                columns: new[] { "ComptesReviewsLikedId", "ReviewsLikedReviewId" },
                values: new object[,]
                {
                    { "2", 3 },
                    { "3", 3 },
                    { "2", 2 },
                    { "3", 2 },
                    { "2", 1 },
                    { "3", 1 },
                    { "2", 4 },
                    { "3", 4 },
                    { "1", 5 },
                    { "3", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompteEvenement");

            migrationBuilder.DropTable(
                name: "CompteReview");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Evenements");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
