using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAgencyVoyavista.Data.Migrations
{
    /// <inheritdoc />
    public partial class removedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NrOfRooms",
                table: "Travelpackage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NrOfRooms",
                table: "Travelpackage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 1,
                column: "NrOfRooms",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 2,
                column: "NrOfRooms",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 3,
                column: "NrOfRooms",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 4,
                column: "NrOfRooms",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 5,
                column: "NrOfRooms",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 6,
                column: "NrOfRooms",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 7,
                column: "NrOfRooms",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 8,
                column: "NrOfRooms",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 9,
                column: "NrOfRooms",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 10,
                column: "NrOfRooms",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 11,
                column: "NrOfRooms",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 12,
                column: "NrOfRooms",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 13,
                column: "NrOfRooms",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 14,
                column: "NrOfRooms",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 15,
                column: "NrOfRooms",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 16,
                column: "NrOfRooms",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 17,
                column: "NrOfRooms",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 18,
                column: "NrOfRooms",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 19,
                column: "NrOfRooms",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 20,
                column: "NrOfRooms",
                value: 15);
        }
    }
}
