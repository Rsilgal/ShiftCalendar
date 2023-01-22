using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftCalendar.Data.Migrations
{
    public partial class InitialDatabaseSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShiftTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Secuencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalendarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secuencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secuencies_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftTypeId = table.Column<int>(type: "int", nullable: false),
                    SecuencyModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Secuencies_SecuencyModelId",
                        column: x => x.SecuencyModelId,
                        principalTable: "Secuencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shifts_ShiftTypes_ShiftTypeId",
                        column: x => x.ShiftTypeId,
                        principalTable: "ShiftTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ShiftId",
                table: "Persons",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Secuencies_CalendarId",
                table: "Secuencies",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_SecuencyModelId",
                table: "Shifts",
                column: "SecuencyModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_ShiftTypeId",
                table: "Shifts",
                column: "ShiftTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Secuencies");

            migrationBuilder.DropTable(
                name: "ShiftTypes");

            migrationBuilder.DropTable(
                name: "Calendars");
        }
    }
}
