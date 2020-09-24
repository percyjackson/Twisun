﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Twisun.Web.Data;

namespace Twisun.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200924021453_AddingDateVersions")]
    partial class AddingDateVersions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Battery", b =>
                {
                    b.Property<int>("Id");

                    b.Property<float>("Capacity");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<float>("OutletLevel");

                    b.Property<float>("SolarLevel");

                    b.Property<float>("StateOfCharge");

                    b.Property<float>("StateOfHealth");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("Id");

                    b.ToTable("Batteries");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("ChargedBatteries");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Model");

                    b.Property<int?>("OwnerId");

                    b.Property<string>("Plaque")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<float?>("SolarKm");

                    b.Property<float?>("TotalKm");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("Plaque")
                        .IsUnique();

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("PartnerId");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.DailySolarEnergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("SolarPanelId");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.HasIndex("SolarPanelId");

                    b.ToTable("DailySolarEnergies");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age");

                    b.Property<DateTime>("Birthday");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Gender")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasMaxLength(1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int?>("TotalPoints");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("Points");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("OwnerId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Range", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Ranges");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.SolarPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("Cells");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<float>("EstimatedEfficiency");

                    b.Property<float>("FoldedArea");

                    b.Property<string>("Serial")
                        .IsRequired();

                    b.Property<float>("UnfoldedArea");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("Id");

                    b.ToTable("SolarPanels");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.UsedCoupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CouponId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("CouponId");

                    b.HasIndex("OwnerId");

                    b.ToTable("UsedCoupons");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address")
                        .HasMaxLength(150);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Document")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PicturePath");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                    b.HasOne("Twisun.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.User")
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

                    b.HasOne("Twisun.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Battery", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.Car", "Car")
                        .WithOne("Battery")
                        .HasForeignKey("Twisun.Web.Data.Entities.Battery", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Car", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.Owner", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Coupon", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.Partner", "Partner")
                        .WithMany("Coupons")
                        .HasForeignKey("PartnerId");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.DailySolarEnergy", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.SolarPanel", "SolarPanel")
                        .WithMany("DailySolarEnergies")
                        .HasForeignKey("SolarPanelId");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Owner", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Partner", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Point", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.Owner", "Owner")
                        .WithMany("Points")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.Range", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.Car", "Car")
                        .WithMany("Ranges")
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.SolarPanel", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.Car", "Car")
                        .WithOne("SolarPanel")
                        .HasForeignKey("Twisun.Web.Data.Entities.SolarPanel", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Twisun.Web.Data.Entities.UsedCoupon", b =>
                {
                    b.HasOne("Twisun.Web.Data.Entities.Coupon", "Coupon")
                        .WithMany("UsedCoupons")
                        .HasForeignKey("CouponId");

                    b.HasOne("Twisun.Web.Data.Entities.Owner", "Owner")
                        .WithMany("UsedCoupons")
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
