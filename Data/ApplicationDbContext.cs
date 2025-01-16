using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelAgencyVoyavista.Models;

namespace TravelAgencyVoyavista.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TravelAgencyVoyavista.Models.Travelpackage> Travelpackage { get; set; } = default!;

        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>().Property(o => o.paymentStatus).HasConversion(v => v ? 1 : 0, v => v == 1);

            modelBuilder.Entity<Order>().Property(o => o.orderActive).HasConversion(v => v ? 1 : 0, v => v == 1);

            modelBuilder.Entity<Travelpackage>().HasData(
                new Travelpackage
                {
                    TravelpackageId = 1,
                    Name = "Hurghada Beach Escape",
                    Location = "Hurghada, Egypt",
                    Price = 1200,
                    imgUrl = "https://cdn.prod.website-files.com/6066dadc7c1455e2933da60a/62d4442dfc49d781aef486e2_TT.jpg",
                    Availablerooms = 5,  // Number of available packages for this location                    
                },
                new Travelpackage
                {
                    TravelpackageId = 2,
                    Name = "Split City Tour",
                    Location = "Split, Croatia",
                    Price = 950,
                    imgUrl = "https://www.stagcroatia.com/images/destination/split-destination-stag-croatia-main.jpg",
                    Availablerooms = 10,                    
                },
                new Travelpackage
                {
                    TravelpackageId = 3,
                    Name = "Dubrovnik Luxury Stay",
                    Location = "Dubrovnik, Croatia",
                    Price = 1500,
                    imgUrl = "https://bilder.apollo.se/dubrovnik-1571405356-401307-ImageGalleryX2.jpg",
                    Availablerooms = 3,                    
                },
                new Travelpackage
                {
                    TravelpackageId = 4,
                    Name = "Phuket Island Adventure",
                    Location = "Phuket, Thailand",
                    Price = 1800,
                    imgUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/4b/5d/c8/caption.jpg?w=1200&h=-1&s=1&cx=2606&cy=1838&chk=v1_a61182fd4040ed4ecc4e",
                    Availablerooms = 8,
                },
                    
                new Travelpackage
                {
                    TravelpackageId = 5,
                    Name = "Bali Paradise Getaway",
                    Location = "Bali, Indonesia",
                    Price = 1300,
                    imgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS0IEvVZvfY_2gIZHjkouzNm13UkbNbeAwYRw&s",
                    Availablerooms = 12,                   
                },
                new Travelpackage
                {
                    TravelpackageId = 6,
                    Name = "Maldives Ocean Retreat",
                    Location = "Maldives",
                    Price = 2200,
                    imgUrl = "https://assets.bwbx.io/images/users/iqjWHBFdfxIU/iFHrNi67BXAo/v1/-1x-1.webp",
                    Availablerooms = 4,                    
                },
                new Travelpackage
                {
                    TravelpackageId = 7,
                    Name = "Santorini Sunset Romance",
                    Location = "Santorini, Greece",
                    Price = 1400,
                    imgUrl = "https://images.pexels.com/photos/16747148/pexels-photo-16747148/free-photo-of-a-couple-standing-on-the-terrace-of-a-building-on-a-greek-island.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Availablerooms = 8,                    
                },
                new Travelpackage
                {
                    TravelpackageId = 8,
                    Name = "Parisian Getaway",
                    Location = "Paris, France",
                    Price = 1600,
                    imgUrl = "https://images.pexels.com/photos/8797910/pexels-photo-8797910.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Availablerooms = 6,                   
                },
                new Travelpackage
                {
                    TravelpackageId = 9,
                    Name = "Tokyo Cultural Journey",
                    Location = "Tokyo, Japan",
                    Price = 1900,
                    imgUrl = "https://images.pexels.com/photos/2385210/pexels-photo-2385210.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Availablerooms = 10,                    
                },
                new Travelpackage
                {
                    TravelpackageId = 10,
                    Name = "Sydney Harbour Experience",
                    Location = "Sydney, Australia",
                    Price = 1700,
                    imgUrl = "https://images.pexels.com/photos/1680249/pexels-photo-1680249.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Availablerooms = 7,                   
                },
                new Travelpackage
                {
                    TravelpackageId = 11,
                    Name = "Barcelona Beach & Culture",
                    Location = "Barcelona, Spain",
                    Price = 1350,
                    imgUrl = "https://images.pexels.com/photos/819764/pexels-photo-819764.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Availablerooms = 5,                   
                },
                new Travelpackage
                {
                    TravelpackageId = 12,
                    Name = "New York City Highlights",
                    Location = "New York City, USA",
                    Price = 2000,
                    imgUrl = "https://images.pexels.com/photos/2168974/pexels-photo-2168974.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Availablerooms = 9,                   
                },
                new Travelpackage 
                { 
                    TravelpackageId = 13, 
                    Name = "Alaskan Wilderness Adventure", 
                    Location = "Alaska, USA", 
                    Price = 2500, 
                    imgUrl = "https://images.pexels.com/photos/4027720/pexels-photo-4027720.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    Availablerooms = 6, 
                }, 
                new Travelpackage 
                { 
                    TravelpackageId = 14, 
                    Name = "Cape Town Coastal Retreat", 
                    Location = "Cape Town, South Africa", 
                    Price = 1600, 
                    imgUrl = "https://images.pexels.com/photos/3736245/pexels-photo-3736245.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    Availablerooms = 10, 
                }, 
                new Travelpackage 
                { 
                    TravelpackageId = 15, 
                    Name = "Rome Historical Tour", 
                    Location = "Rome, Italy", 
                    Price = 1400, 
                    imgUrl = "https://images.pexels.com/photos/1701595/pexels-photo-1701595.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    Availablerooms = 8, 
                }, 
                new Travelpackage 
                { 
                    TravelpackageId = 16, 
                    Name = "Machu Picchu Exploration", 
                    Location = "Machu Picchu, Peru", 
                    Price = 1800, 
                    imgUrl = "https://images.pexels.com/photos/90597/pexels-photo-90597.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    Availablerooms = 7
                }, 
                new Travelpackage 
                { 
                    TravelpackageId = 17, 
                    Name = "Iceland Northern Lights", 
                    Location = "Reykjavik, Iceland", 
                    Price = 2200, 
                    imgUrl = "https://images.pexels.com/photos/356831/pexels-photo-356831.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    Availablerooms = 5
                }, 
                new Travelpackage 
                { 
                    TravelpackageId = 18, 
                    Name = "Hawaii Tropical Escape", 
                    Location = "Hawaii, USA", 
                    Price = 2400, 
                    imgUrl = "https://images.pexels.com/photos/60217/pexels-photo-60217.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    Availablerooms = 9, 
                }, 
                new Travelpackage 
                { 
                    TravelpackageId = 19, 
                    Name = "Swiss Alps Skiing", 
                    Location = "Zermatt, Switzerland", 
                    Price = 3000, 
                    imgUrl = "https://images.pexels.com/photos/12572226/pexels-photo-12572226.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    Availablerooms = 8, 
                }, 
                new Travelpackage
                {
                    TravelpackageId = 20,
                    Name = "Great Wall of China Tour",
                    Location = "Beijing, China",
                    Price = 2100,
                    imgUrl = "https://images.pexels.com/photos/2412603/pexels-photo-2412603.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Availablerooms = 7,                    
                }
            );

            // Seeding images
            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    imageId = 1,
                    ImgURL = "https://images.pexels.com/photos/24913567/pexels-photo-24913567/free-photo-of-stad-landmarke-byggnad-lyx.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    TravelpackageId = 1
                },
                new Image
                {
                    imageId = 2,
                    ImgURL = "https://images.pexels.com/photos/164595/pexels-photo-164595.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 1
                },
                new Image
                {
                    imageId = 3,
                    ImgURL = "https://images.pexels.com/photos/2265876/pexels-photo-2265876.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 2
                },
                new Image
                {
                    imageId = 4,
                    ImgURL = "https://images.pexels.com/photos/3580532/pexels-photo-3580532.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 3
                },
                new Image
                {
                    imageId = 5,
                    ImgURL = "https://images.pexels.com/photos/1368043/pexels-photo-1368043.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 4
                },
                new Image
                {
                    imageId = 6,
                    ImgURL = "https://images.pexels.com/photos/2412297/pexels-photo-2412297.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 5
                },
                new Image
                {
                    imageId = 7,
                    ImgURL = "https://images.pexels.com/photos/1483053/pexels-photo-1483053.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 6
                },
                new Image
                {
                    imageId = 8,
                    ImgURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR4lF_4-cqKq-aGzdgOrDtyPBHPeaLnW8qxnA&s",
                    TravelpackageId = 1
                },
                new Image
                {
                    imageId = 9,
                    ImgURL = "https://media.tacdn.com/media/attractions-splice-spp-674x446/10/13/52/2a.jpg",
                    TravelpackageId = 1
                },
                new Image
                {
                    imageId = 10,
                    ImgURL = "https://img.freepik.com/free-photo/small-hotel-room-interior-with-double-bed-bathroom_1262-12489.jpg",
                    TravelpackageId = 2,
                },
                new Image
                {
                    imageId = 11,
                    ImgURL = "https://qtxasset.com/quartz/qcloud1/media/image/2016-11/luxury-hotel.jpg?VersionId=jwpLrYKSbPkvgQIy8HQPTLTvCWi9RJhS",
                    TravelpackageId = 3,
                },
                new Image
                {
                    imageId = 12,
                    ImgURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS09JEjmDafYMOJnDDacTHcLQrvcW9GZw3ZHA&s",
                    TravelpackageId = 4,
                },
                new Image
                {
                    imageId = 13,
                    ImgURL = "https://d2e5ushqwiltxm.cloudfront.net/wp-content/uploads/sites/51/2023/05/23110128/Pullman-Panwa-Deluxe-Room-With-Sea-View-Twin-Bed.jpg",
                    TravelpackageId = 5,
                },
                new Image
                {
                    imageId = 14,
                    ImgURL = "https://cdn-5d68e683f911c80950255463.closte.com/wp-content/uploads/2019/05/home.dataphoto.1.jpg",
                    TravelpackageId = 6,
                },
                new Image
                {
                    imageId = 15,
                    ImgURL = "https://content.phuket101.net/wp-content/uploads/20240923094253/Bathroom-at-Courtyard-Phuket-Patong-Beach-Resort.jpg",
                    TravelpackageId = 6,
                },

                new Image
                {
                    imageId = 16,
                    ImgURL = "https://images.pexels.com/photos/163864/santorini-oia-greece-travel-163864.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 7
                },
                new Image
                {
                    imageId = 17,
                    ImgURL = "https://images.pexels.com/photos/1029021/pexels-photo-1029021.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 7
                },
                new Image
                {
                    imageId = 18,
                    ImgURL = "https://images.pexels.com/photos/1010646/pexels-photo-1010646.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 7
                },
                // Images for Parisian Getaway
                new Image
                {
                    imageId = 19,
                    ImgURL = "https://images.pexels.com/photos/1530259/pexels-photo-1530259.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 8
                },
                new Image
                {
                    imageId = 20,
                    ImgURL = "https://images.pexels.com/photos/3201763/pexels-photo-3201763.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 8
                },
                new Image
                {
                    imageId = 21,
                    ImgURL = "https://images.pexels.com/photos/2363/france-landmark-lights-night.jpg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 8
                },
                // Images for Tokyo Cultural Journey
                new Image
                {
                    imageId = 22,
                    ImgURL = "https://images.pexels.com/photos/2506923/pexels-photo-2506923.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 9
                },
                new Image
                {
                    imageId = 23,
                    ImgURL = "https://images.pexels.com/photos/96422/pexels-photo-96422.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 9
                },
                new Image
                {
                    imageId = 24,
                    ImgURL = "https://images.pexels.com/photos/161251/senso-ji-temple-japan-kyoto-landmark-161251.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 9
                },
                // Images for Sydney Harbour Experience
                new Image
                {
                    imageId = 25,
                    ImgURL = "https://images.pexels.com/photos/635628/pexels-photo-635628.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 10
                },
                new Image
                {
                    imageId = 26,
                    ImgURL = "https://images.pexels.com/photos/236510/pexels-photo-236510.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 10
                },
                new Image
                {
                    imageId = 27,
                    ImgURL = "https://images.pexels.com/photos/279746/pexels-photo-279746.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 10
                },
                // Images for Barcelona Beach & Culture
                new Image
                {
                    imageId = 28,
                    ImgURL = "https://images.pexels.com/photos/998735/pexels-photo-998735.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 11
                },
                new Image
                {
                    imageId = 29,
                    ImgURL = "https://images.pexels.com/photos/54308/man-fan-person-football-54308.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 11
                },
                new Image
                {
                    imageId = 30,
                    ImgURL = "https://images.pexels.com/photos/271639/pexels-photo-271639.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 11
                },
                // Images for New York City Highlights
                new Image
                {
                    imageId = 31,
                    ImgURL = "https://images.pexels.com/photos/1400249/pexels-photo-1400249.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 12
                },
                new Image
                {
                    imageId = 32,
                    ImgURL = "https://images.pexels.com/photos/1239162/pexels-photo-1239162.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 12
                },
                new Image
                {
                    imageId = 33,
                    ImgURL = "https://images.pexels.com/photos/3201765/pexels-photo-3201765.jpeg?auto=compress&cs=tinysrgb&w=600",
                    TravelpackageId = 12
                },
                new Image 
                { 
                    imageId = 34, 
                    ImgURL = "https://images.pexels.com/photos/41004/alaska-wilderness-sky-aurora-borealis-41004.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 13 }, 
                new Image 
                { 
                    imageId = 35, 
                    ImgURL = "https://images.pexels.com/photos/27244381/pexels-photo-27244381/free-photo-of-glaciar-island-smaltande-is.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 13 }, 
                new Image 
                { 
                    imageId = 36, 
                    ImgURL = "https://images.pexels.com/photos/2024881/pexels-photo-2024881.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 13 }, 
                new Image 
                { 
                    imageId = 37, 
                    ImgURL = "https://images.pexels.com/photos/271624/pexels-photo-271624.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 13 },
                new Image 
                { 
                    imageId = 38, 
                    ImgURL = "https://images.pexels.com/photos/259447/pexels-photo-259447.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 14 }, 
                new Image 
                { 
                    imageId = 39, 
                    ImgURL = "https://images.pexels.com/photos/1631066/pexels-photo-1631066.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 14 }, 
                new Image 
                { 
                    imageId = 40, 
                    ImgURL = "https://images.pexels.com/photos/261102/pexels-photo-261102.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 14 }, 
                new Image 
                { 
                    imageId = 41, 
                    ImgURL = "https://images.pexels.com/photos/775219/pexels-photo-775219.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 14 }, 
                new Image 
                { 
                    imageId = 42, 
                    ImgURL = "https://images.pexels.com/photos/2225442/pexels-photo-2225442.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 15 }, 
                new Image 
                { 
                    imageId = 43, 
                    ImgURL = "https://images.pexels.com/photos/326709/pexels-photo-326709.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 15 }, 
                new Image 
                { 
                    imageId = 44, 
                    ImgURL = "https://images.pexels.com/photos/1797158/pexels-photo-1797158.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 15 }, 
                new Image 
                { 
                    imageId = 45, 
                    ImgURL = "https://images.pexels.com/photos/262047/pexels-photo-262047.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 15 },
                new Image 
                { 
                    imageId = 46, 
                    ImgURL = "https://images.pexels.com/photos/2929906/pexels-photo-2929906.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 16 }, 
                new Image 
                { 
                    imageId = 47, 
                    ImgURL = "https://images.pexels.com/photos/22484290/pexels-photo-22484290/free-photo-of-landmarke-resa-turister-sightseeing.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 16 }, 
                new Image 
                { 
                    imageId = 48, 
                    ImgURL = "https://images.pexels.com/photos/2539397/pexels-photo-2539397.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 16 }, 
                new Image 
                { 
                    imageId = 49,
                    ImgURL = "https://images.pexels.com/photos/271618/pexels-photo-271618.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 16 }, 
                new Image 
                { 
                    imageId = 50, 
                    ImgURL = "https://images.pexels.com/photos/831056/pexels-photo-831056.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 17 }, 
                new Image 
                { 
                    imageId = 51, 
                    ImgURL = "https://images.pexels.com/photos/831088/pexels-photo-831088.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 17 },
                new Image 
                { 
                    imageId = 52, 
                    ImgURL = "https://images.pexels.com/photos/2989054/pexels-photo-2989054.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 17 }, 
                new Image 
                { 
                    imageId = 53, 
                    ImgURL = "https://images.pexels.com/photos/17926439/pexels-photo-17926439/free-photo-of-natur-vatten-sommar-fotografi.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 17 },
                new Image 
                { 
                    imageId = 54, 
                    ImgURL = "https://images.pexels.com/photos/4319752/pexels-photo-4319752.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 18 }, 
                new Image 
                { 
                    imageId = 55, 
                    ImgURL = "https://images.pexels.com/photos/7502344/pexels-photo-7502344.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 18 }, 
                new Image 
                { 
                    imageId = 56, 
                    ImgURL = "https://images.pexels.com/photos/1151831/pexels-photo-1151831.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 18 }, 
                new Image 
                { 
                    imageId = 57, 
                    ImgURL = "https://images.pexels.com/photos/2521620/pexels-photo-2521620.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 18 },
                new Image 
                { 
                    imageId = 58, 
                    ImgURL = "https://images.pexels.com/photos/30214548/pexels-photo-30214548/free-photo-of-vintervandring-i-snowy-planica-slovenien.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 19 }, 
                new Image 
                { 
                    imageId = 59, 
                    ImgURL = "https://images.pexels.com/photos/30214514/pexels-photo-30214514/free-photo-of-skidakningsaventyr-pa-planicas-snoiga-backar.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 19 }, 
                new Image 
                { 
                    imageId = 60, 
                    ImgURL = "https://images.pexels.com/photos/5378694/pexels-photo-5378694.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 19 }, 
                new Image 
                { imageId = 61, 
                    ImgURL = "https://images.pexels.com/photos/30210635/pexels-photo-30210635.jpeg?auto=compress&cs=tinysrgb&w=600", 
                    TravelpackageId = 19 }, 
                new Image 
                { 
                    imageId = 62, 
                    ImgURL = "https://img.static-kl.com/images/media/E5F5918C-9435-4CE6-9775780B48F3C39D?w=960", 
                    TravelpackageId = 20 }, 
                new Image 
                { 
                    imageId = 63, 
                    ImgURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5qlzreMAprAZsTaFYGjfWKSpKIw2S_Q6v_A&s", 
                    TravelpackageId = 20 }, 
                new Image 
                { 
                    imageId = 64, 
                    ImgURL = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/309714618.jpg?k=cf15fa21a64c02a82e52c26008bbf9c810d8e12be1dc31ef7f54ffec4177259b&o=&hp=1", 
                    TravelpackageId = 20 }, 
                new Image 
                { 
                    imageId = 65, 
                    ImgURL = "https://www.flamingotravels.co.in/_next/image?url=https%3A%2F%2Fimgcdn.flamingotravels.co.in%2FImages%2FPlacesOfInterest%2FGreat%20Wall%20Of%20China.jpg&w=1080&q=90", 
                    TravelpackageId = 20 }
            );

        }
        
    }
}
