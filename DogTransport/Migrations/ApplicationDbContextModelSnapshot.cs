﻿// <auto-generated />
using System;
using DogTransport.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogTransport.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("DogTransport.Areas.Identity.Data.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("First")
                        .IsRequired();

                    b.Property<string>("Last")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<Guid?>("RescueID");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("RescueID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DogTransport.Models.Comment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<DateTime>("Date");

                    b.Property<Guid?>("LegID");

                    b.Property<string>("Text");

                    b.Property<Guid?>("TransportID");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.HasIndex("LegID");

                    b.HasIndex("TransportID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("DogTransport.Models.Dog", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aggressive");

                    b.Property<bool>("BiteHistory");

                    b.Property<string>("Description");

                    b.Property<Guid?>("LegID");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.Property<string>("SpecialNeeds");

                    b.Property<bool>("kennel");

                    b.HasKey("ID");

                    b.HasIndex("LegID");

                    b.HasIndex("OwnerId");

                    b.ToTable("Dog");
                });

            modelBuilder.Entity("DogTransport.Models.Leg", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bathroom");

                    b.Property<DateTime>("Date");

                    b.Property<Guid?>("DestinationID");

                    b.Property<bool>("Fed");

                    b.Property<string>("OrganizerId");

                    b.Property<Guid?>("OriginID");

                    b.Property<Guid?>("TransportID");

                    b.Property<bool>("Watered");

                    b.HasKey("ID");

                    b.HasIndex("DestinationID");

                    b.HasIndex("OrganizerId");

                    b.HasIndex("OriginID");

                    b.HasIndex("TransportID");

                    b.ToTable("Leg");
                });

            modelBuilder.Entity("DogTransport.Models.Location", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<string>("City");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("DogTransport.Models.Rescue", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Rescue");
                });

            modelBuilder.Entity("DogTransport.Models.Transport", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid?>("DestinationID");

                    b.Property<string>("OrganizerId");

                    b.Property<Guid?>("OriginID");

                    b.HasKey("ID");

                    b.HasIndex("DestinationID");

                    b.HasIndex("OrganizerId");

                    b.HasIndex("OriginID");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DogTransport.Areas.Identity.Data.AspNetUser", b =>
                {
                    b.HasOne("DogTransport.Models.Rescue", "Rescue")
                        .WithMany("Admins")
                        .HasForeignKey("RescueID");
                });

            modelBuilder.Entity("DogTransport.Models.Comment", b =>
                {
                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("DogTransport.Models.Leg")
                        .WithMany("Comments")
                        .HasForeignKey("LegID");

                    b.HasOne("DogTransport.Models.Transport")
                        .WithMany("Comments")
                        .HasForeignKey("TransportID");
                });

            modelBuilder.Entity("DogTransport.Models.Dog", b =>
                {
                    b.HasOne("DogTransport.Models.Leg")
                        .WithMany("Dogs")
                        .HasForeignKey("LegID");

                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("DogTransport.Models.Leg", b =>
                {
                    b.HasOne("DogTransport.Models.Location", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID");

                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser", "Organizer")
                        .WithMany()
                        .HasForeignKey("OrganizerId");

                    b.HasOne("DogTransport.Models.Location", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginID");

                    b.HasOne("DogTransport.Models.Transport")
                        .WithMany("Legs")
                        .HasForeignKey("TransportID");
                });

            modelBuilder.Entity("DogTransport.Models.Transport", b =>
                {
                    b.HasOne("DogTransport.Models.Location", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationID");

                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser", "Organizer")
                        .WithMany()
                        .HasForeignKey("OrganizerId");

                    b.HasOne("DogTransport.Models.Location", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DogTransport.Areas.Identity.Data.AspNetUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}