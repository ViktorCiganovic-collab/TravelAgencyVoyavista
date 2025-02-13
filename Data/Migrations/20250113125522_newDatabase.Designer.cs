﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAgencyVoyavista.Data;

#nullable disable

namespace TravelAgencyVoyavista.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250113125522_newDatabase")]
    partial class newDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TravelAgencyVoyavista.Models.Image", b =>
                {
                    b.Property<int>("imageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("imageId"));

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelpackageId")
                        .HasColumnType("int");

                    b.HasKey("imageId");

                    b.HasIndex("TravelpackageId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            imageId = 1,
                            ImgURL = "https://images.pexels.com/photos/24913567/pexels-photo-24913567/free-photo-of-stad-landmarke-byggnad-lyx.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            TravelpackageId = 1
                        },
                        new
                        {
                            imageId = 2,
                            ImgURL = "https://images.pexels.com/photos/164595/pexels-photo-164595.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 1
                        },
                        new
                        {
                            imageId = 3,
                            ImgURL = "https://images.pexels.com/photos/2265876/pexels-photo-2265876.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 2
                        },
                        new
                        {
                            imageId = 4,
                            ImgURL = "https://images.pexels.com/photos/3580532/pexels-photo-3580532.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 3
                        },
                        new
                        {
                            imageId = 5,
                            ImgURL = "https://images.pexels.com/photos/1368043/pexels-photo-1368043.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 4
                        },
                        new
                        {
                            imageId = 6,
                            ImgURL = "https://images.pexels.com/photos/2412297/pexels-photo-2412297.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 5
                        },
                        new
                        {
                            imageId = 7,
                            ImgURL = "https://images.pexels.com/photos/1483053/pexels-photo-1483053.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 6
                        },
                        new
                        {
                            imageId = 8,
                            ImgURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR4lF_4-cqKq-aGzdgOrDtyPBHPeaLnW8qxnA&s",
                            TravelpackageId = 1
                        },
                        new
                        {
                            imageId = 9,
                            ImgURL = "https://media.tacdn.com/media/attractions-splice-spp-674x446/10/13/52/2a.jpg",
                            TravelpackageId = 1
                        },
                        new
                        {
                            imageId = 10,
                            ImgURL = "https://img.freepik.com/free-photo/small-hotel-room-interior-with-double-bed-bathroom_1262-12489.jpg",
                            TravelpackageId = 2
                        },
                        new
                        {
                            imageId = 11,
                            ImgURL = "https://qtxasset.com/quartz/qcloud1/media/image/2016-11/luxury-hotel.jpg?VersionId=jwpLrYKSbPkvgQIy8HQPTLTvCWi9RJhS",
                            TravelpackageId = 3
                        },
                        new
                        {
                            imageId = 12,
                            ImgURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS09JEjmDafYMOJnDDacTHcLQrvcW9GZw3ZHA&s",
                            TravelpackageId = 4
                        },
                        new
                        {
                            imageId = 13,
                            ImgURL = "https://d2e5ushqwiltxm.cloudfront.net/wp-content/uploads/sites/51/2023/05/23110128/Pullman-Panwa-Deluxe-Room-With-Sea-View-Twin-Bed.jpg",
                            TravelpackageId = 5
                        },
                        new
                        {
                            imageId = 14,
                            ImgURL = "https://cdn-5d68e683f911c80950255463.closte.com/wp-content/uploads/2019/05/home.dataphoto.1.jpg",
                            TravelpackageId = 6
                        },
                        new
                        {
                            imageId = 15,
                            ImgURL = "https://content.phuket101.net/wp-content/uploads/20240923094253/Bathroom-at-Courtyard-Phuket-Patong-Beach-Resort.jpg",
                            TravelpackageId = 6
                        },
                        new
                        {
                            imageId = 16,
                            ImgURL = "https://images.pexels.com/photos/163864/santorini-oia-greece-travel-163864.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 7
                        },
                        new
                        {
                            imageId = 17,
                            ImgURL = "https://images.pexels.com/photos/1029021/pexels-photo-1029021.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 7
                        },
                        new
                        {
                            imageId = 18,
                            ImgURL = "https://images.pexels.com/photos/1010646/pexels-photo-1010646.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 7
                        },
                        new
                        {
                            imageId = 19,
                            ImgURL = "https://images.pexels.com/photos/1530259/pexels-photo-1530259.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 8
                        },
                        new
                        {
                            imageId = 20,
                            ImgURL = "https://images.pexels.com/photos/3201763/pexels-photo-3201763.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 8
                        },
                        new
                        {
                            imageId = 21,
                            ImgURL = "https://images.pexels.com/photos/2363/france-landmark-lights-night.jpg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 8
                        },
                        new
                        {
                            imageId = 22,
                            ImgURL = "https://images.pexels.com/photos/2506923/pexels-photo-2506923.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 9
                        },
                        new
                        {
                            imageId = 23,
                            ImgURL = "https://images.pexels.com/photos/96422/pexels-photo-96422.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 9
                        },
                        new
                        {
                            imageId = 24,
                            ImgURL = "https://images.pexels.com/photos/161251/senso-ji-temple-japan-kyoto-landmark-161251.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 9
                        },
                        new
                        {
                            imageId = 25,
                            ImgURL = "https://images.pexels.com/photos/635628/pexels-photo-635628.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 10
                        },
                        new
                        {
                            imageId = 26,
                            ImgURL = "https://images.pexels.com/photos/236510/pexels-photo-236510.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 10
                        },
                        new
                        {
                            imageId = 27,
                            ImgURL = "https://images.pexels.com/photos/279746/pexels-photo-279746.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 10
                        },
                        new
                        {
                            imageId = 28,
                            ImgURL = "https://images.pexels.com/photos/998735/pexels-photo-998735.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 11
                        },
                        new
                        {
                            imageId = 29,
                            ImgURL = "https://images.pexels.com/photos/54308/man-fan-person-football-54308.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 11
                        },
                        new
                        {
                            imageId = 30,
                            ImgURL = "https://images.pexels.com/photos/271639/pexels-photo-271639.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 11
                        },
                        new
                        {
                            imageId = 31,
                            ImgURL = "https://images.pexels.com/photos/1400249/pexels-photo-1400249.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 12
                        },
                        new
                        {
                            imageId = 32,
                            ImgURL = "https://images.pexels.com/photos/1239162/pexels-photo-1239162.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 12
                        },
                        new
                        {
                            imageId = 33,
                            ImgURL = "https://images.pexels.com/photos/3201765/pexels-photo-3201765.jpeg?auto=compress&cs=tinysrgb&w=600",
                            TravelpackageId = 12
                        });
                });

            modelBuilder.Entity("TravelAgencyVoyavista.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TravelpackageId")
                        .HasColumnType("int");

                    b.Property<int>("numberOfPersons")
                        .HasColumnType("int");

                    b.Property<int>("orderActive")
                        .HasColumnType("int");

                    b.Property<int>("paymentStatus")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("TravelpackageId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TravelAgencyVoyavista.Models.Travelpackage", b =>
                {
                    b.Property<int>("TravelpackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TravelpackageId"));

                    b.Property<int>("Availablerooms")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("imgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TravelpackageId");

                    b.ToTable("Travelpackage");

                    b.HasData(
                        new
                        {
                            TravelpackageId = 1,
                            Availablerooms = 5,
                            Location = "Hurghada, Egypt",
                            Name = "Hurghada Beach Escape",
                            NrOfRooms = 20,
                            Price = 1200,
                            imgUrl = "https://cdn.prod.website-files.com/6066dadc7c1455e2933da60a/62d4442dfc49d781aef486e2_TT.jpg"
                        },
                        new
                        {
                            TravelpackageId = 2,
                            Availablerooms = 10,
                            Location = "Split, Croatia",
                            Name = "Split City Tour",
                            NrOfRooms = 15,
                            Price = 950,
                            imgUrl = "https://www.stagcroatia.com/images/destination/split-destination-stag-croatia-main.jpg"
                        },
                        new
                        {
                            TravelpackageId = 3,
                            Availablerooms = 3,
                            Location = "Dubrovnik, Croatia",
                            Name = "Dubrovnik Luxury Stay",
                            NrOfRooms = 8,
                            Price = 1500,
                            imgUrl = "https://bilder.apollo.se/dubrovnik-1571405356-401307-ImageGalleryX2.jpg"
                        },
                        new
                        {
                            TravelpackageId = 4,
                            Availablerooms = 8,
                            Location = "Phuket, Thailand",
                            Name = "Phuket Island Adventure",
                            NrOfRooms = 25,
                            Price = 1800,
                            imgUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/4b/5d/c8/caption.jpg?w=1200&h=-1&s=1&cx=2606&cy=1838&chk=v1_a61182fd4040ed4ecc4e"
                        },
                        new
                        {
                            TravelpackageId = 5,
                            Availablerooms = 12,
                            Location = "Bali, Indonesia",
                            Name = "Bali Paradise Getaway",
                            NrOfRooms = 30,
                            Price = 1300,
                            imgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS0IEvVZvfY_2gIZHjkouzNm13UkbNbeAwYRw&s"
                        },
                        new
                        {
                            TravelpackageId = 6,
                            Availablerooms = 4,
                            Location = "Maldives",
                            Name = "Maldives Ocean Retreat",
                            NrOfRooms = 10,
                            Price = 2200,
                            imgUrl = "https://assets.bwbx.io/images/users/iqjWHBFdfxIU/iFHrNi67BXAo/v1/-1x-1.webp"
                        },
                        new
                        {
                            TravelpackageId = 7,
                            Availablerooms = 8,
                            Location = "Santorini, Greece",
                            Name = "Santorini Sunset Romance",
                            NrOfRooms = 18,
                            Price = 1400,
                            imgUrl = "https://images.pexels.com/photos/16747148/pexels-photo-16747148/free-photo-of-a-couple-standing-on-the-terrace-of-a-building-on-a-greek-island.jpeg?auto=compress&cs=tinysrgb&w=600"
                        },
                        new
                        {
                            TravelpackageId = 8,
                            Availablerooms = 6,
                            Location = "Paris, France",
                            Name = "Parisian Getaway",
                            NrOfRooms = 12,
                            Price = 1600,
                            imgUrl = "https://images.pexels.com/photos/8797910/pexels-photo-8797910.jpeg?auto=compress&cs=tinysrgb&w=600"
                        },
                        new
                        {
                            TravelpackageId = 9,
                            Availablerooms = 10,
                            Location = "Tokyo, Japan",
                            Name = "Tokyo Cultural Journey",
                            NrOfRooms = 22,
                            Price = 1900,
                            imgUrl = "https://images.pexels.com/photos/2385210/pexels-photo-2385210.jpeg?auto=compress&cs=tinysrgb&w=600"
                        },
                        new
                        {
                            TravelpackageId = 10,
                            Availablerooms = 7,
                            Location = "Sydney, Australia",
                            Name = "Sydney Harbour Experience",
                            NrOfRooms = 14,
                            Price = 1700,
                            imgUrl = "https://images.pexels.com/photos/1680249/pexels-photo-1680249.jpeg?auto=compress&cs=tinysrgb&w=600"
                        },
                        new
                        {
                            TravelpackageId = 11,
                            Availablerooms = 5,
                            Location = "Barcelona, Spain",
                            Name = "Barcelona Beach & Culture",
                            NrOfRooms = 20,
                            Price = 1350,
                            imgUrl = "https://images.pexels.com/photos/819764/pexels-photo-819764.jpeg?auto=compress&cs=tinysrgb&w=600"
                        },
                        new
                        {
                            TravelpackageId = 12,
                            Availablerooms = 9,
                            Location = "New York City, USA",
                            Name = "New York City Highlights",
                            NrOfRooms = 16,
                            Price = 2000,
                            imgUrl = "https://images.pexels.com/photos/2168974/pexels-photo-2168974.jpeg?auto=compress&cs=tinysrgb&w=600"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelAgencyVoyavista.Models.Image", b =>
                {
                    b.HasOne("TravelAgencyVoyavista.Models.Travelpackage", "Travelpackage")
                        .WithMany("Images")
                        .HasForeignKey("TravelpackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Travelpackage");
                });

            modelBuilder.Entity("TravelAgencyVoyavista.Models.Order", b =>
                {
                    b.HasOne("TravelAgencyVoyavista.Models.Travelpackage", "Travelpackage")
                        .WithMany("Orders")
                        .HasForeignKey("TravelpackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Travelpackage");
                });

            modelBuilder.Entity("TravelAgencyVoyavista.Models.Travelpackage", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
