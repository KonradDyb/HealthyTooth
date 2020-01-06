using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyTooth.Migrations
{
    public partial class FixedVisit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitDetails",
                table: "VisitDetails");

            migrationBuilder.DropColumn(
                name: "VisitDetailsId",
                table: "VisitDetails");

            migrationBuilder.AddColumn<int>(
                name: "VisitDetailId",
                table: "VisitDetails",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitDetails",
                table: "VisitDetails",
                column: "VisitDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitDetails",
                table: "VisitDetails");

            migrationBuilder.DropColumn(
                name: "VisitDetailId",
                table: "VisitDetails");

            migrationBuilder.AddColumn<int>(
                name: "VisitDetailsId",
                table: "VisitDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitDetails",
                table: "VisitDetails",
                column: "VisitDetailsId");
        }
    }
}
