using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Migrations.Crm
{
    public partial class CrmMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Adress = table.Column<string>(nullable: true),
                    CUI = table.Column<string>(nullable: true),
                    CallBackDate = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    CourseLvl1 = table.Column<string>(nullable: true),
                    CourseLvl2 = table.Column<string>(nullable: true),
                    CourseLvl3 = table.Column<string>(nullable: true),
                    DateOfTheFifthContact = table.Column<DateTime>(nullable: false),
                    DateOfTheFirstContact = table.Column<DateTime>(nullable: false),
                    DateOfTheFourthContact = table.Column<DateTime>(nullable: false),
                    DateOfTheSecondContact = table.Column<DateTime>(nullable: false),
                    DateOfTheThirdContact = table.Column<DateTime>(nullable: false),
                    Discution1 = table.Column<string>(nullable: true),
                    Discution2 = table.Column<string>(nullable: true),
                    Discution3 = table.Column<string>(nullable: true),
                    Discution4 = table.Column<string>(nullable: true),
                    Discution5 = table.Column<string>(nullable: true),
                    FieldOfActivity = table.Column<string>(nullable: true),
                    HasAutoPark = table.Column<bool>(nullable: false),
                    J = table.Column<string>(nullable: true),
                    LongDiscutions = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NrOfDrivers = table.Column<int>(nullable: false),
                    PreviousContract = table.Column<bool>(nullable: false),
                    ServicesOfInterest = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    CNP = table.Column<long>(nullable: false),
                    Courses = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    ContactPersonId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    BirthDate = table.Column<string>(nullable: true),
                    CNP = table.Column<long>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<long>(nullable: false),
                    PositionInCompany = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => x.ContactPersonId);
                    table.ForeignKey(
                        name: "FK_ContactPerson_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_CompanyId",
                table: "ContactPerson",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactPerson");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
