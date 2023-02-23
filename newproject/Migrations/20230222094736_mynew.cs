using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newproject.Migrations
{
    /// <inheritdoc />
    public partial class mynew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityPosed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfPosting = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AncOpds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOftheMother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    contactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANCRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfVisit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DailyLogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncOpds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AncOpds_DailyLogs_DailyLogId",
                        column: x => x.DailyLogId,
                        principalTable: "DailyLogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AncOpds_DailyLogId",
                table: "AncOpds",
                column: "DailyLogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AncOpds");

            migrationBuilder.DropTable(
                name: "DailyLogs");
        }
    }
}
