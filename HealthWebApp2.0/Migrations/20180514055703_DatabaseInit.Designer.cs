﻿// <auto-generated />
using HealthWebApp2._0.Data;
using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Household;
using HealthWebApp2._0.Data.EntityModel.PhilHealthFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HealthWebApp2._0.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180514055703_DatabaseInit")]
    partial class DatabaseInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.Barangay", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityMunicipalityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityMunicipalityId");

                    b.ToTable("Barangay");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.BarangayOfficial", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("BarangayId");

                    b.Property<int>("DesignationId");

                    b.Property<long>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("BarangayId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("PersonId");

                    b.ToTable("BarangayOfficial");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.CityMunicipality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Designation");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.PhilArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PhilArea");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("RegionId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PhilAreaId");

                    b.HasKey("Id");

                    b.HasIndex("PhilAreaId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("EmployeeId");

                    b.Property<string>("LongName");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Household.HouseholdProfileDetailMOdel", b =>
                {
                    b.Property<long>("PersonId");

                    b.Property<long>("HouseholdProfileId");

                    b.Property<int>("RelationToHead");

                    b.HasKey("PersonId");

                    b.HasIndex("HouseholdProfileId");

                    b.ToTable("HouseholdProfileDetailMOdel");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Household.HouseholdProfile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<long>("BarangayId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateTimeLastUpdated");

                    b.Property<long>("EmployeeId");

                    b.Property<string>("Note");

                    b.Property<string>("ProfileId");

                    b.HasKey("Id");

                    b.HasIndex("BarangayId");

                    b.ToTable("HouseholdProfile");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.NameTitle", b =>
                {
                    b.Property<int>("NameTitleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("NameTitleId");

                    b.ToTable("NameTitle");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CivilStatus");

                    b.Property<string>("ContactNumber");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateTimeLastUpdated");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("EmergencyContactNumber");

                    b.Property<string>("EmergencyContactPerson");

                    b.Property<long>("EmployeeId");

                    b.Property<int>("ExtensionName");

                    b.Property<long?>("FamilyId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(30);

                    b.Property<int>("NameTitleId");

                    b.Property<bool>("PersonConsent");

                    b.Property<string>("RelationshipToPatient");

                    b.Property<int>("ReligionId");

                    b.Property<int>("Sex");

                    b.Property<int>("WorkId");

                    b.HasKey("Id");

                    b.HasIndex("NameTitleId");

                    b.HasIndex("ReligionId");

                    b.HasIndex("WorkId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.PhilHealthFolder.PhilHealth", b =>
                {
                    b.Property<long>("PersonId");

                    b.Property<int>("Category");

                    b.Property<DateTime>("DateAssigned");

                    b.Property<long>("EmployeeId");

                    b.Property<int>("EmployerType");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<int>("Individual");

                    b.Property<bool>("Lifetime");

                    b.Property<string>("PhilHealthId");

                    b.Property<int>("Sponsored");

                    b.Property<int>("StatusType");

                    b.HasKey("PersonId");

                    b.ToTable("PhilHealth");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Religion", b =>
                {
                    b.Property<int>("ReligionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ReligionId");

                    b.ToTable("Religion");
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Work", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("WorkId");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("HealthWebApp2._0.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

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

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

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

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.Barangay", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Barangays.CityMunicipality", "CityMunicipality")
                        .WithMany("Barangays")
                        .HasForeignKey("CityMunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.BarangayOfficial", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Barangays.Barangay", "Barangay")
                        .WithMany("BarangayOfficials")
                        .HasForeignKey("BarangayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Barangays.Designation", "Position")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Person", "Officer")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.CityMunicipality", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Barangays.Province", "Province")
                        .WithMany("CityMunicipalities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.Province", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Barangays.Region", "Region")
                        .WithMany("Provinces")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Barangays.Region", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Barangays.PhilArea", "PhilArea")
                        .WithMany("Regions")
                        .HasForeignKey("PhilAreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Household.HouseholdProfileDetailMOdel", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Household.HouseholdProfile", "HouseholdProfile")
                        .WithMany("HouseholdMembers")
                        .HasForeignKey("HouseholdProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Person", "Person")
                        .WithOne("HouseholdProfileDetailMOdel")
                        .HasForeignKey("HealthWebApp2._0.Data.EntityModel.Household.HouseholdProfileDetailMOdel", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Household.HouseholdProfile", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Barangays.Barangay", "Barangay")
                        .WithMany("HouseholdProfiles")
                        .HasForeignKey("BarangayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.Person", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.NameTitle", "NameTitle")
                        .WithMany()
                        .HasForeignKey("NameTitleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Religion", "Religion")
                        .WithMany()
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Work", "Work")
                        .WithMany()
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp2._0.Data.EntityModel.PhilHealthFolder.PhilHealth", b =>
                {
                    b.HasOne("HealthWebApp2._0.Data.EntityModel.Person", "Person")
                        .WithOne("PhilHealth")
                        .HasForeignKey("HealthWebApp2._0.Data.EntityModel.PhilHealthFolder.PhilHealth", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                    b.HasOne("HealthWebApp2._0.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HealthWebApp2._0.Models.ApplicationUser")
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

                    b.HasOne("HealthWebApp2._0.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HealthWebApp2._0.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
