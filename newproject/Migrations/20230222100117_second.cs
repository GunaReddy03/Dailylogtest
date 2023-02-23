using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newproject.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dailylog_Triages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    examination_type = table.Column<bool>(type: "bit", nullable: true),
                    NameOftheMother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    contactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofVisit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeofVisit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfAssesment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LMP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EDD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pathways_Of_Care = table.Column<bool>(type: "bit", nullable: true),
                    DateOfAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfRefferalOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DailyLogId = table.Column<int>(type: "int", nullable: true),
                    DemographicDetailsTriage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status_Of_Mother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traige_Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vitals_Triage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailylog_Triages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dailylog_Triages_DailyLogs_DailyLogId",
                        column: x => x.DailyLogId,
                        principalTable: "DailyLogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dailylog_Triages_DailyLogId",
                table: "dailylog_Triages",
                column: "DailyLogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dailylog_Triages");
        }
    }
}
