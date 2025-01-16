using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelAgencyVoyavista.Data.Migrations
{
    /// <inheritdoc />
    public partial class moreTravelPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Travelpackage",
                columns: new[] { "TravelpackageId", "Availablerooms", "Location", "Name", "NrOfRooms", "Price", "imgUrl" },
                values: new object[,]
                {
                    { 13, 6, "Alaska, USA", "Alaskan Wilderness Adventure", 12, 2500, "https://images.pexels.com/photos/4027720/pexels-photo-4027720.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 14, 10, "Cape Town, South Africa", "Cape Town Coastal Retreat", 25, 1600, "https://images.pexels.com/photos/3736245/pexels-photo-3736245.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 15, 8, "Rome, Italy", "Rome Historical Tour", 18, 1400, "https://images.pexels.com/photos/1701595/pexels-photo-1701595.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 16, 7, "Machu Picchu, Peru", "Machu Picchu Exploration", 14, 1800, "https://images.pexels.com/photos/90597/pexels-photo-90597.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 17, 5, "Reykjavik, Iceland", "Iceland Northern Lights", 12, 2200, "https://images.pexels.com/photos/356831/pexels-photo-356831.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 18, 9, "Hawaii, USA", "Hawaii Tropical Escape", 20, 2400, "https://images.pexels.com/photos/60217/pexels-photo-60217.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 19, 8, "Zermatt, Switzerland", "Swiss Alps Skiing", 16, 3000, "https://images.pexels.com/photos/12572226/pexels-photo-12572226.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 20, 7, "Beijing, China", "Great Wall of China Tour", 15, 2100, "https://images.pexels.com/photos/2412603/pexels-photo-2412603.jpeg?auto=compress&cs=tinysrgb&w=600" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "imageId", "ImgURL", "TravelpackageId" },
                values: new object[,]
                {
                    { 34, "https://images.pexels.com/photos/41004/alaska-wilderness-sky-aurora-borealis-41004.jpeg?auto=compress&cs=tinysrgb&w=600", 13 },
                    { 35, "https://images.pexels.com/photos/27244381/pexels-photo-27244381/free-photo-of-glaciar-island-smaltande-is.jpeg?auto=compress&cs=tinysrgb&w=600", 13 },
                    { 36, "https://images.pexels.com/photos/2024881/pexels-photo-2024881.jpeg?auto=compress&cs=tinysrgb&w=600", 13 },
                    { 37, "https://images.pexels.com/photos/271624/pexels-photo-271624.jpeg?auto=compress&cs=tinysrgb&w=600", 13 },
                    { 38, "https://images.pexels.com/photos/259447/pexels-photo-259447.jpeg?auto=compress&cs=tinysrgb&w=600", 14 },
                    { 39, "https://images.pexels.com/photos/1631066/pexels-photo-1631066.jpeg?auto=compress&cs=tinysrgb&w=600", 14 },
                    { 40, "https://images.pexels.com/photos/261102/pexels-photo-261102.jpeg?auto=compress&cs=tinysrgb&w=600", 14 },
                    { 41, "https://images.pexels.com/photos/775219/pexels-photo-775219.jpeg?auto=compress&cs=tinysrgb&w=600", 14 },
                    { 42, "https://images.pexels.com/photos/2225442/pexels-photo-2225442.jpeg?auto=compress&cs=tinysrgb&w=600", 15 },
                    { 43, "https://images.pexels.com/photos/326709/pexels-photo-326709.jpeg?auto=compress&cs=tinysrgb&w=600", 15 },
                    { 44, "https://images.pexels.com/photos/1797158/pexels-photo-1797158.jpeg?auto=compress&cs=tinysrgb&w=600", 15 },
                    { 45, "https://images.pexels.com/photos/262047/pexels-photo-262047.jpeg?auto=compress&cs=tinysrgb&w=600", 15 },
                    { 46, "https://images.pexels.com/photos/2929906/pexels-photo-2929906.jpeg?auto=compress&cs=tinysrgb&w=600", 16 },
                    { 47, "https://images.pexels.com/photos/22484290/pexels-photo-22484290/free-photo-of-landmarke-resa-turister-sightseeing.jpeg?auto=compress&cs=tinysrgb&w=600", 16 },
                    { 48, "https://images.pexels.com/photos/2539397/pexels-photo-2539397.jpeg?auto=compress&cs=tinysrgb&w=600", 16 },
                    { 49, "https://images.pexels.com/photos/271618/pexels-photo-271618.jpeg?auto=compress&cs=tinysrgb&w=600", 16 },
                    { 50, "https://images.pexels.com/photos/831056/pexels-photo-831056.jpeg?auto=compress&cs=tinysrgb&w=600", 17 },
                    { 51, "https://images.pexels.com/photos/831088/pexels-photo-831088.jpeg?auto=compress&cs=tinysrgb&w=600", 17 },
                    { 52, "https://images.pexels.com/photos/2989054/pexels-photo-2989054.jpeg?auto=compress&cs=tinysrgb&w=600", 17 },
                    { 53, "https://images.pexels.com/photos/17926439/pexels-photo-17926439/free-photo-of-natur-vatten-sommar-fotografi.jpeg?auto=compress&cs=tinysrgb&w=600", 17 },
                    { 54, "https://images.pexels.com/photos/4319752/pexels-photo-4319752.jpeg?auto=compress&cs=tinysrgb&w=600", 18 },
                    { 55, "https://images.pexels.com/photos/7502344/pexels-photo-7502344.jpeg?auto=compress&cs=tinysrgb&w=600", 18 },
                    { 56, "https://images.pexels.com/photos/1151831/pexels-photo-1151831.jpeg?auto=compress&cs=tinysrgb&w=600", 18 },
                    { 57, "https://images.pexels.com/photos/2521620/pexels-photo-2521620.jpeg?auto=compress&cs=tinysrgb&w=600", 18 },
                    { 58, "https://images.pexels.com/photos/30214548/pexels-photo-30214548/free-photo-of-vintervandring-i-snowy-planica-slovenien.jpeg?auto=compress&cs=tinysrgb&w=600", 19 },
                    { 59, "https://images.pexels.com/photos/30214514/pexels-photo-30214514/free-photo-of-skidakningsaventyr-pa-planicas-snoiga-backar.jpeg?auto=compress&cs=tinysrgb&w=600", 19 },
                    { 60, "https://images.pexels.com/photos/5378694/pexels-photo-5378694.jpeg?auto=compress&cs=tinysrgb&w=600", 19 },
                    { 61, "https://images.pexels.com/photos/30210635/pexels-photo-30210635.jpeg?auto=compress&cs=tinysrgb&w=600", 19 },
                    { 62, "https://img.static-kl.com/images/media/E5F5918C-9435-4CE6-9775780B48F3C39D?w=960", 20 },
                    { 63, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5qlzreMAprAZsTaFYGjfWKSpKIw2S_Q6v_A&s", 20 },
                    { 64, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309714618.jpg?k=cf15fa21a64c02a82e52c26008bbf9c810d8e12be1dc31ef7f54ffec4177259b&o=&hp=1", 20 },
                    { 65, "https://www.flamingotravels.co.in/_next/image?url=https%3A%2F%2Fimgcdn.flamingotravels.co.in%2FImages%2FPlacesOfInterest%2FGreat%20Wall%20Of%20China.jpg&w=1080&q=90", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "imageId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Travelpackage",
                keyColumn: "TravelpackageId",
                keyValue: 20);
        }
    }
}
