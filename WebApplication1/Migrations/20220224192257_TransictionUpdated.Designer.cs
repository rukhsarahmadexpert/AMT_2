﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220224192257_TransictionUpdated")]
    partial class TransictionUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.AccountsInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountTitle")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Code");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("HeadAccountId");

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("HeadAccountId");

                    b.ToTable("AccountsInformations");

                    b.HasData(
                        new { Id = 1, AccountTitle = "Petty cash", Code = 10001, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 755, DateTimeKind.Local), HeadAccountId = 1, IsActive = true }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.BloodGroupInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("BloodGroupInformations");

                    b.HasData(
                        new { Id = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 740, DateTimeKind.Local), IsActive = true, Name = "A+" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.ControlAccountInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code");

                    b.Property<string>("ControlAccountName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("ControlAccountInformations");

                    b.HasData(
                        new { Id = 1, Code = 1001, ControlAccountName = "ASSETS", CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 749, DateTimeKind.Local), IsActive = true }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.CustomerInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(300);

                    b.Property<string>("Area");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ContactPersonName");

                    b.Property<string>("Country");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LandLine");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("State");

                    b.Property<string>("TRNNumber");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("CustomerInformations");

                    b.HasData(
                        new { Id = 1, Address = "nest 18, street k5 Allon", Area = "Mufraq", CompanyName = "Test Name", ContactPersonName = "Seed Name", Country = "UAE", CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 737, DateTimeKind.Local), Description = "this is test description from seed", Email = "this@test.com", IsActive = true, LandLine = "34564613564", MobileNumber = "121313454112", State = "Abu Dhabi", TRNNumber = "123456789123456" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.DepartmentInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("DepartmentInformations");

                    b.HasData(
                        new { Id = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 720, DateTimeKind.Local), IsActive = true, Name = "Accounting" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.DesignationInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("DesignationInformations");

                    b.HasData(
                        new { Id = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 727, DateTimeKind.Local), IsActive = true, Name = "Driver" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.EmployeeInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<int>("Age");

                    b.Property<int>("BloodGroupId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DateofBirth");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<int>("DesignationId");

                    b.Property<DateTime>("DrivingLicienceExpiry");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("EmergencyContactNumber");

                    b.Property<int>("GenderId");

                    b.Property<DateTime>("HireDate");

                    b.Property<DateTime>("IdCardExpiry");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("PassportExpiry");

                    b.Property<DateTime>("VisaExpiry");

                    b.HasKey("Id");

                    b.HasIndex("BloodGroupId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("GenderId");

                    b.ToTable("EmployeeInformations");

                    b.HasData(
                        new { Id = 1, Address = "jos 10 faren street s6, no 1099", Age = 25, BloodGroupId = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 745, DateTimeKind.Local), DateofBirth = new DateTime(2022, 2, 24, 23, 22, 56, 745, DateTimeKind.Local), DepartmentId = 1, Description = "this is test Employee From Seed", DesignationId = 1, DrivingLicienceExpiry = new DateTime(2022, 2, 24, 23, 22, 56, 745, DateTimeKind.Local), EmailAddress = "test@gmail.com", EmergencyContactNumber = "64648464412", GenderId = 1, HireDate = new DateTime(2022, 2, 24, 23, 22, 56, 745, DateTimeKind.Local), IdCardExpiry = new DateTime(2022, 2, 24, 23, 22, 56, 745, DateTimeKind.Local), ImageUrl = "jas.jpg", IsActive = true, MobileNumber = "1231464612", Name = "Test Name", PassportExpiry = new DateTime(2022, 2, 24, 23, 22, 56, 745, DateTimeKind.Local), VisaExpiry = new DateTime(2022, 2, 24, 23, 22, 56, 745, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.GenderInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new { Id = 1, GenderName = "Male" },
                        new { Id = 2, GenderName = "Female" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.HeadAccountsInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code");

                    b.Property<int>("ControlAccountId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("HeadAccountTitle")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.HasIndex("ControlAccountId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("HeadAccountsInformations");

                    b.HasData(
                        new { Id = 1, Code = 1001, ControlAccountId = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 752, DateTimeKind.Local), HeadAccountTitle = "Current Assets", IsActive = true }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.ProductInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UnitId");

                    b.ToTable("ProductInfos");

                    b.HasData(
                        new { Id = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 732, DateTimeKind.Local), Description = "this is from seed,for test purpose", IsActive = true, Name = "Letter", UnitId = 1 }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.TrackUpdateInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AfterUpdate");

                    b.Property<string>("BeforeUpdate");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("UpdateInfo");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("TrackUpdateInformations");

                    b.HasData(
                        new { Id = 1, AfterUpdate = "Driver Name", BeforeUpdate = "Driver", CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 747, DateTimeKind.Local), IsActive = true, UpdateInfo = "Driver Update to Driver Name" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.TransictionInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<float?>("Cr");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<float?>("Dr");

                    b.Property<DateTime>("ForDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("TransictionIdentity");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("TransictionInformations");

                    b.HasData(
                        new { Id = 1, AccountId = 2, Cr = 0f, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 759, DateTimeKind.Local), Description = "Owner invest as a cash", Dr = 5000f, ForDate = new DateTime(2022, 2, 24, 23, 22, 56, 759, DateTimeKind.Local), IsActive = true, TransictionIdentity = 1245654284 },
                        new { Id = 2, AccountId = 1020, Cr = 5000f, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 759, DateTimeKind.Local), Description = "Owner invest as a cash", Dr = 0f, ForDate = new DateTime(2022, 2, 24, 23, 22, 56, 759, DateTimeKind.Local), IsActive = true, TransictionIdentity = 1245654284 }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.UnitInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("UnitInformations");

                    b.HasData(
                        new { Id = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 730, DateTimeKind.Local), IsActive = true, Name = "Letter" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.UserInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("GenderId");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("UserInformations");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 720, DateTimeKind.Local), FullName = "Admin", GenderId = 1, IsActive = true, UserName = "admin@gmail.com", UserPassword = "12345678" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.VehicleInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<string>("Comments");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("InsuranceExpiry");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Model");

                    b.Property<DateTime>("MulkiyaExpiry");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("RegisterdRegion")
                        .HasMaxLength(1000);

                    b.Property<string>("TCNumber");

                    b.Property<int>("VehicleTypeId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("VehicleInformation");

                    b.HasData(
                        new { Id = 1, Brand = "Toyota", Color = "Red", Comments = "this from seed for test", CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 727, DateTimeKind.Local), InsuranceExpiry = new DateTime(2022, 2, 24, 23, 22, 56, 727, DateTimeKind.Local), IsActive = true, Model = "2008", MulkiyaExpiry = new DateTime(2022, 2, 24, 23, 22, 56, 727, DateTimeKind.Local), PlateNumber = "2005", RegisterdRegion = "Abu Dhabi", TCNumber = "13131", VehicleTypeId = 1 }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.VehicleTypeInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("VehicleTypeInformations");

                    b.HasData(
                        new { Id = 1, CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 740, DateTimeKind.Local), IsActive = true, TypeName = "Heavy Vehicle" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.VenderInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(300);

                    b.Property<string>("Area");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ContactPersonName");

                    b.Property<string>("Country");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LandLine");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("State");

                    b.Property<string>("TRNNumber");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("VenderInformations");

                    b.HasData(
                        new { Id = 1, Address = "nest 18, street k5 Allon", Area = "Mufraq", CompanyName = "Test Vender", ContactPersonName = "Seed Vender", Country = "UAE", CreatedBy = 1, CreatedDate = new DateTime(2022, 2, 24, 23, 22, 56, 739, DateTimeKind.Local), Description = "this is test description from seed", Email = "this@test.com", IsActive = true, LandLine = "34564613564", MobileNumber = "121313454112", State = "Abu Dhabi", TRNNumber = "123456789123456" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.AccountsInformation", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("AccountsInformation")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.HeadAccountsInformations", "HeadAccountsInformations")
                        .WithMany("AccountsInformations")
                        .HasForeignKey("HeadAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.BloodGroupInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("BloodGroupInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.ControlAccountInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("ControlAccountInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.CustomerInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("CustomerInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.DepartmentInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("DepartmentInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.DesignationInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("DesignationInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.EmployeeInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.BloodGroupInformations", "BloodGroupInformations")
                        .WithMany("EmployeeInformations")
                        .HasForeignKey("BloodGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("EmployeeInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.DepartmentInformations", "DepartmentInformations")
                        .WithMany("EmployeeInformations")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.DesignationInformations", "DesignationInformations")
                        .WithMany("EmployeeInformations")
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.GenderInformations", "GenderInformations")
                        .WithMany("EmployeeInformations")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.HeadAccountsInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.ControlAccountInformations", "ControlAccountInformations")
                        .WithMany("HeadAccountsInformations")
                        .HasForeignKey("ControlAccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("HeadAccountsInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.ProductInfo", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("ProductInfos")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.UnitInformations", "UnitInformations")
                        .WithMany("ProductInfos")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.TrackUpdateInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("TrackUpdateInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.TransictionInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.AccountsInformation", "AccountsInformation")
                        .WithMany("TransictionInformations")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("TransictionInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.UnitInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("UnitInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.UserInformation", b =>
                {
                    b.HasOne("WebApplication1.Models.GenderInformations", "Gender")
                        .WithMany("UserInformations")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.VehicleInformation", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("VehicleInformation")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.VehicleTypeInformations", "VehicleTypeInformations")
                        .WithMany("VehicleInformation")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.VehicleTypeInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("VehicleTypeInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.VenderInformations", b =>
                {
                    b.HasOne("WebApplication1.Models.UserInformation", "UserInformation")
                        .WithMany("VenderInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
