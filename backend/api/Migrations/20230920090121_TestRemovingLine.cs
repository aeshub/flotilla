using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class TestRemovingLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Areas_DefaultLocalizationAreaId",
                table: "Decks");

            migrationBuilder.DropIndex(
                name: "IX_Decks_DefaultLocalizationAreaId",
                table: "Decks");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_DefaultLocalizationAreaId",
                table: "Decks",
                column: "DefaultLocalizationAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Decks_Areas_DefaultLocalizationAreaId",
                table: "Decks",
                column: "DefaultLocalizationAreaId",
                principalTable: "Areas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Areas_DefaultLocalizationAreaId",
                table: "Decks");

            migrationBuilder.DropIndex(
                name: "IX_Decks_DefaultLocalizationAreaId",
                table: "Decks");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_DefaultLocalizationAreaId",
                table: "Decks",
                column: "DefaultLocalizationAreaId",
                unique: true,
                filter: "[DefaultLocalizationAreaId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Decks_Areas_DefaultLocalizationAreaId",
                table: "Decks",
                column: "DefaultLocalizationAreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
