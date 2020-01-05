using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyTooth.Migrations
{
    public partial class VisitSummaryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitSummaryItems",
                columns: table => new
                {
                    VisitSummaryItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(nullable: true),
                    VisitSummaryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitSummaryItems", x => x.VisitSummaryItemId);
                    table.ForeignKey(
                        name: "FK_VisitSummaryItems_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisitSummaryItems_DoctorId",
                table: "VisitSummaryItems",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitSummaryItems");
        }
    }
}
