using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace WebAppDemo.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CaseName = table.Column<string>(type: "text", nullable: true),
                    CaseNumber = table.Column<int>(type: "int", nullable: false),
                    CaseType = table.Column<string>(type: "text", nullable: true),
                    CaseStatus = table.Column<string>(type: "text", nullable: true),
                    CaseDateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    CaseDateModified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MailClientFirstName = table.Column<string>(type: "text", nullable: true),
                    MailClientLastName = table.Column<string>(type: "text", nullable: true),
                    MailClientOtherName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    MailClientPhoto = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    MailClientTag = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChiefJudges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    OtherName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    ChiefJudgePhoto = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    MailClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefJudges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiefJudges_MailClients_MailClientId",
                        column: x => x.MailClientId,
                        principalTable: "MailClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiefJudgeCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ChiefJudgeId = table.Column<int>(type: "int", nullable: false),
                    CaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefJudgeCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiefJudgeCases_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiefJudgeCases_ChiefJudges_ChiefJudgeId",
                        column: x => x.ChiefJudgeId,
                        principalTable: "ChiefJudges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiefJudgeCases_CaseId",
                table: "ChiefJudgeCases",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiefJudgeCases_ChiefJudgeId",
                table: "ChiefJudgeCases",
                column: "ChiefJudgeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiefJudges_MailClientId",
                table: "ChiefJudges",
                column: "MailClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiefJudgeCases");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "ChiefJudges");

            migrationBuilder.DropTable(
                name: "MailClients");
        }
    }
}
