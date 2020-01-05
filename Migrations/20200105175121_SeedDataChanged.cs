using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyTooth.Migrations
{
    public partial class SeedDataChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "ServiceDescription",
                table: "Doctors",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                column: "ServiceDescription",
                value: "Ortodoncja");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                column: "ServiceDescription",
                value: "Implantologia");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                column: "ServiceDescription",
                value: "Protetyka");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceDescription",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                column: "ShortDescription",
                value: "Usługa: Ortodoncja");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                column: "ShortDescription",
                value: "Usługa: Implantologia");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                column: "ShortDescription",
                value: "Usługa: Protetyka");
        }
    }
}
