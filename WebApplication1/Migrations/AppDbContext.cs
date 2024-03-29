﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.ModelBinders;
using WebApplication1.Models;

namespace WebApplication1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<GenderInformations> Genders { get; set; }
        public DbSet<DepartmentInformations> DepartmentInformations { get; set; }
        public DbSet<DesignationInformations> DesignationInformations { get; set; }
        public DbSet<TrackUpdateInformations> TrackUpdateInformations { get; set; }
        public DbSet<BloodGroupInformations> BloodGroupInformations { get; set; }
        public DbSet<EmployeeInformations> EmployeeInformations { get; set; }
        public DbSet<UnitInformations> UnitInformations { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<CustomerInformations> CustomerInformations { get; set; }
        public DbSet<VenderInformations> VenderInformations { get; set; }
        public DbSet<VehicleTypeInformations> VehicleTypeInformations { get; set; }
        public DbSet<VehicleInformation> VehicleInformation { get; set; }
        public DbSet<ControlAccountInformations> ControlAccountInformations { get; set; }
        public DbSet<HeadAccountsInformations> HeadAccountsInformations { get; set; }
        public DbSet<AccountsInformation> AccountsInformations { get; set; }
        public DbSet<TransictionInformations> TransictionInformations { get; set; }
        public DbSet<QuotationInformation> QuotationInformation { get; set; }
        public DbSet<QuotationDetails> QuotationDetails { get; set; }
        public DbSet<PaymentTypeInformations> PaymentTypes { get; set; }
        public DbSet<ExpenseInformation> ExpenseInformations { get; set; }
        public DbSet<ExpenseDetailsInformations> ExpenseDetailsInformations { get; set; }


              
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}