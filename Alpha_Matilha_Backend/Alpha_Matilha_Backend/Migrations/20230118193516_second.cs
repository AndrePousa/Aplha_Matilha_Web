using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlphaMatilhaBackend.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Person_PersonID_Person",
                table: "Dog");

            migrationBuilder.DropIndex(
                name: "IX_Dog_PersonID_Person",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "PersonID_Person",
                table: "Dog");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonID_Person",
                table: "Dog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dog_PersonID_Person",
                table: "Dog",
                column: "PersonID_Person");

            migrationBuilder.AddForeignKey(
                name: "FK_Dog_Person_PersonID_Person",
                table: "Dog",
                column: "PersonID_Person",
                principalTable: "Person",
                principalColumn: "ID_Person");
        }
    }
}
