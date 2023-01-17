using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlphaMatilhaBackend.Migrations
{
    /// <inheritdoc />
    public partial class FistMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address_Person",
                columns: table => new
                {
                    IDAddress = table.Column<int>(name: "ID_Address", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPerson = table.Column<int>(name: "ID_Person", type: "int", nullable: false),
                    NameStreet = table.Column<string>(name: "Name_Street", type: "nvarchar(max)", nullable: false),
                    NumberHome = table.Column<int>(name: "Number_Home", type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(name: "Zip_Code", type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address_Person", x => x.IDAddress);
                });

            migrationBuilder.CreateTable(
                name: "Classes_Dog",
                columns: table => new
                {
                    IDClass = table.Column<int>(name: "ID_Class", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDDog = table.Column<int>(name: "ID_Dog", type: "int", nullable: false),
                    RegistrationClass = table.Column<DateTime>(name: "Registration_Class", type: "datetime2", nullable: false),
                    Confirmed = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes_Dog", x => x.IDClass);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    IDPerson = table.Column<int>(name: "ID_Person", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First_Name", type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classification = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(name: "Registration_Date", type: "datetime2", nullable: false),
                    SEX = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.IDPerson);
                });

            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    IDDog = table.Column<int>(name: "ID_Dog", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDClient = table.Column<int>(name: "ID_Client", type: "int", nullable: false),
                    IDTrainer = table.Column<int>(name: "ID_Trainer", type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    StartTraining = table.Column<DateTime>(name: "Start_Training", type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    EndOfTheContract = table.Column<DateTime>(name: "End_Of_The_Contract", type: "datetime2", nullable: false),
                    PersonIDPerson = table.Column<int>(name: "PersonID_Person", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.IDDog);
                    table.ForeignKey(
                        name: "FK_Dog_Person_PersonID_Person",
                        column: x => x.PersonIDPerson,
                        principalTable: "Person",
                        principalColumn: "ID_Person");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dog_PersonID_Person",
                table: "Dog",
                column: "PersonID_Person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address_Person");

            migrationBuilder.DropTable(
                name: "Classes_Dog");

            migrationBuilder.DropTable(
                name: "Dog");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
