using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelAgencyVoyavista.Data.Migrations
{
    /// <inheritdoc />
    public partial class newDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Travelpackage",
                columns: table => new
                {
                    TravelpackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Availablerooms = table.Column<int>(type: "int", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrOfRooms = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travelpackage", x => x.TravelpackageId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    imageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TravelpackageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.imageId);
                    table.ForeignKey(
                        name: "FK_Images_Travelpackage_TravelpackageId",
                        column: x => x.TravelpackageId,
                        principalTable: "Travelpackage",
                        principalColumn: "TravelpackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfPersons = table.Column<int>(type: "int", nullable: false),
                    paymentStatus = table.Column<int>(type: "int", nullable: false),
                    orderActive = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TravelpackageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Travelpackage_TravelpackageId",
                        column: x => x.TravelpackageId,
                        principalTable: "Travelpackage",
                        principalColumn: "TravelpackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Travelpackage",
                columns: new[] { "TravelpackageId", "Availablerooms", "Location", "Name", "NrOfRooms", "Price", "imgUrl" },
                values: new object[,]
                {
                    { 1, 5, "Hurghada, Egypt", "Hurghada Beach Escape", 20, 1200, "https://cdn.prod.website-files.com/6066dadc7c1455e2933da60a/62d4442dfc49d781aef486e2_TT.jpg" },
                    { 2, 10, "Split, Croatia", "Split City Tour", 15, 950, "https://www.stagcroatia.com/images/destination/split-destination-stag-croatia-main.jpg" },
                    { 3, 3, "Dubrovnik, Croatia", "Dubrovnik Luxury Stay", 8, 1500, "https://bilder.apollo.se/dubrovnik-1571405356-401307-ImageGalleryX2.jpg" },
                    { 4, 8, "Phuket, Thailand", "Phuket Island Adventure", 25, 1800, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/4b/5d/c8/caption.jpg?w=1200&h=-1&s=1&cx=2606&cy=1838&chk=v1_a61182fd4040ed4ecc4e" },
                    { 5, 12, "Bali, Indonesia", "Bali Paradise Getaway", 30, 1300, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS0IEvVZvfY_2gIZHjkouzNm13UkbNbeAwYRw&s" },
                    { 6, 4, "Maldives", "Maldives Ocean Retreat", 10, 2200, "https://assets.bwbx.io/images/users/iqjWHBFdfxIU/iFHrNi67BXAo/v1/-1x-1.webp" },
                    { 7, 8, "Santorini, Greece", "Santorini Sunset Romance", 18, 1400, "https://images.pexels.com/photos/16747148/pexels-photo-16747148/free-photo-of-a-couple-standing-on-the-terrace-of-a-building-on-a-greek-island.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 8, 6, "Paris, France", "Parisian Getaway", 12, 1600, "https://images.pexels.com/photos/8797910/pexels-photo-8797910.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 9, 10, "Tokyo, Japan", "Tokyo Cultural Journey", 22, 1900, "https://images.pexels.com/photos/2385210/pexels-photo-2385210.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 10, 7, "Sydney, Australia", "Sydney Harbour Experience", 14, 1700, "https://images.pexels.com/photos/1680249/pexels-photo-1680249.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 11, 5, "Barcelona, Spain", "Barcelona Beach & Culture", 20, 1350, "https://images.pexels.com/photos/819764/pexels-photo-819764.jpeg?auto=compress&cs=tinysrgb&w=600" },
                    { 12, 9, "New York City, USA", "New York City Highlights", 16, 2000, "https://images.pexels.com/photos/2168974/pexels-photo-2168974.jpeg?auto=compress&cs=tinysrgb&w=600" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "imageId", "ImgURL", "TravelpackageId" },
                values: new object[,]
                {
                    { 1, "https://images.pexels.com/photos/24913567/pexels-photo-24913567/free-photo-of-stad-landmarke-byggnad-lyx.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", 1 },
                    { 2, "https://images.pexels.com/photos/164595/pexels-photo-164595.jpeg?auto=compress&cs=tinysrgb&w=600", 1 },
                    { 3, "https://images.pexels.com/photos/2265876/pexels-photo-2265876.jpeg?auto=compress&cs=tinysrgb&w=600", 2 },
                    { 4, "https://images.pexels.com/photos/3580532/pexels-photo-3580532.jpeg?auto=compress&cs=tinysrgb&w=600", 3 },
                    { 5, "https://images.pexels.com/photos/1368043/pexels-photo-1368043.jpeg?auto=compress&cs=tinysrgb&w=600", 4 },
                    { 6, "https://images.pexels.com/photos/2412297/pexels-photo-2412297.jpeg?auto=compress&cs=tinysrgb&w=600", 5 },
                    { 7, "https://images.pexels.com/photos/1483053/pexels-photo-1483053.jpeg?auto=compress&cs=tinysrgb&w=600", 6 },
                    { 8, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR4lF_4-cqKq-aGzdgOrDtyPBHPeaLnW8qxnA&s", 1 },
                    { 9, "https://media.tacdn.com/media/attractions-splice-spp-674x446/10/13/52/2a.jpg", 1 },
                    { 10, "https://img.freepik.com/free-photo/small-hotel-room-interior-with-double-bed-bathroom_1262-12489.jpg", 2 },
                    { 11, "https://qtxasset.com/quartz/qcloud1/media/image/2016-11/luxury-hotel.jpg?VersionId=jwpLrYKSbPkvgQIy8HQPTLTvCWi9RJhS", 3 },
                    { 12, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS09JEjmDafYMOJnDDacTHcLQrvcW9GZw3ZHA&s", 4 },
                    { 13, "https://d2e5ushqwiltxm.cloudfront.net/wp-content/uploads/sites/51/2023/05/23110128/Pullman-Panwa-Deluxe-Room-With-Sea-View-Twin-Bed.jpg", 5 },
                    { 14, "https://cdn-5d68e683f911c80950255463.closte.com/wp-content/uploads/2019/05/home.dataphoto.1.jpg", 6 },
                    { 15, "https://content.phuket101.net/wp-content/uploads/20240923094253/Bathroom-at-Courtyard-Phuket-Patong-Beach-Resort.jpg", 6 },
                    { 16, "https://images.pexels.com/photos/163864/santorini-oia-greece-travel-163864.jpeg?auto=compress&cs=tinysrgb&w=600", 7 },
                    { 17, "https://images.pexels.com/photos/1029021/pexels-photo-1029021.jpeg?auto=compress&cs=tinysrgb&w=600", 7 },
                    { 18, "https://images.pexels.com/photos/1010646/pexels-photo-1010646.jpeg?auto=compress&cs=tinysrgb&w=600", 7 },
                    { 19, "https://images.pexels.com/photos/1530259/pexels-photo-1530259.jpeg?auto=compress&cs=tinysrgb&w=600", 8 },
                    { 20, "https://images.pexels.com/photos/3201763/pexels-photo-3201763.jpeg?auto=compress&cs=tinysrgb&w=600", 8 },
                    { 21, "https://images.pexels.com/photos/2363/france-landmark-lights-night.jpg?auto=compress&cs=tinysrgb&w=600", 8 },
                    { 22, "https://images.pexels.com/photos/2506923/pexels-photo-2506923.jpeg?auto=compress&cs=tinysrgb&w=600", 9 },
                    { 23, "https://images.pexels.com/photos/96422/pexels-photo-96422.jpeg?auto=compress&cs=tinysrgb&w=600", 9 },
                    { 24, "https://images.pexels.com/photos/161251/senso-ji-temple-japan-kyoto-landmark-161251.jpeg?auto=compress&cs=tinysrgb&w=600", 9 },
                    { 25, "https://images.pexels.com/photos/635628/pexels-photo-635628.jpeg?auto=compress&cs=tinysrgb&w=600", 10 },
                    { 26, "https://images.pexels.com/photos/236510/pexels-photo-236510.jpeg?auto=compress&cs=tinysrgb&w=600", 10 },
                    { 27, "https://images.pexels.com/photos/279746/pexels-photo-279746.jpeg?auto=compress&cs=tinysrgb&w=600", 10 },
                    { 28, "https://images.pexels.com/photos/998735/pexels-photo-998735.jpeg?auto=compress&cs=tinysrgb&w=600", 11 },
                    { 29, "https://images.pexels.com/photos/54308/man-fan-person-football-54308.jpeg?auto=compress&cs=tinysrgb&w=600", 11 },
                    { 30, "https://images.pexels.com/photos/271639/pexels-photo-271639.jpeg?auto=compress&cs=tinysrgb&w=600", 11 },
                    { 31, "https://images.pexels.com/photos/1400249/pexels-photo-1400249.jpeg?auto=compress&cs=tinysrgb&w=600", 12 },
                    { 32, "https://images.pexels.com/photos/1239162/pexels-photo-1239162.jpeg?auto=compress&cs=tinysrgb&w=600", 12 },
                    { 33, "https://images.pexels.com/photos/3201765/pexels-photo-3201765.jpeg?auto=compress&cs=tinysrgb&w=600", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_TravelpackageId",
                table: "Images",
                column: "TravelpackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TravelpackageId",
                table: "Orders",
                column: "TravelpackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Travelpackage");
        }
    }
}
