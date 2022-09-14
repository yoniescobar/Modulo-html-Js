﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CapaDato.Models;

namespace CapaDato.Datos
{
    public partial class Northwind : DbContext
    {
        public Northwind()
        {
        }

        public Northwind(DbContextOptions<Northwind> options)
            : base(options)
        {
        }

        public virtual DbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Category_Sales_for_1997> Category_Sales_for_1997s { get; set; } = null!;
        public virtual DbSet<Current_Product_List> Current_Product_Lists { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; } = null!;
        public virtual DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Order_Detail> Order_Details { get; set; } = null!;
        public virtual DbSet<Order_Details_Extended> Order_Details_Extendeds { get; set; } = null!;
        public virtual DbSet<Order_Subtotal> Order_Subtotals { get; set; } = null!;
        public virtual DbSet<Orders_Qry> Orders_Qries { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Product_Sales_for_1997> Product_Sales_for_1997s { get; set; } = null!;
        public virtual DbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; } = null!;
        public virtual DbSet<Products_by_Category> Products_by_Categories { get; set; } = null!;
        public virtual DbSet<Quarterly_Order> Quarterly_Orders { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; set; } = null!;
        public virtual DbSet<Sales_by_Category> Sales_by_Categories { get; set; } = null!;
        public virtual DbSet<Shipper> Shippers { get; set; } = null!;
        public virtual DbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; set; } = null!;
        public virtual DbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Territory> Territories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=MSI; Initial Catalog=Northwind; user id=soporte; password=12003906;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alphabetical_list_of_product>(entity =>
            {
                entity.ToView("Alphabetical list of products");
            });

            modelBuilder.Entity<Category_Sales_for_1997>(entity =>
            {
                entity.ToView("Category Sales for 1997");
            });

            modelBuilder.Entity<Current_Product_List>(entity =>
            {
                entity.ToView("Current Product List");

                entity.Property(e => e.ProductID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerID).IsFixedLength();

                entity.HasMany(d => d.CustomerTypes)
                    .WithMany(p => p.Customers)
                    .UsingEntity<Dictionary<string, object>>(
                        "CustomerCustomerDemo",
                        l => l.HasOne<CustomerDemographic>().WithMany().HasForeignKey("CustomerTypeID").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CustomerCustomerDemo"),
                        r => r.HasOne<Customer>().WithMany().HasForeignKey("CustomerID").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CustomerCustomerDemo_Customers"),
                        j =>
                        {
                            j.HasKey("CustomerID", "CustomerTypeID").IsClustered(false);

                            j.ToTable("CustomerCustomerDemo");

                            j.IndexerProperty<string>("CustomerID").HasMaxLength(5).IsFixedLength();

                            j.IndexerProperty<string>("CustomerTypeID").HasMaxLength(10).IsFixedLength();
                        });
            });

            modelBuilder.Entity<CustomerDemographic>(entity =>
            {
                entity.HasKey(e => e.CustomerTypeID)
                    .IsClustered(false);

                entity.Property(e => e.CustomerTypeID).IsFixedLength();
            });

            modelBuilder.Entity<Customer_and_Suppliers_by_City>(entity =>
            {
                entity.ToView("Customer and Suppliers by City");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.ReportsToNavigation)
                    .WithMany(p => p.InverseReportsToNavigation)
                    .HasForeignKey(d => d.ReportsTo)
                    .HasConstraintName("FK_Employees_Employees");

                entity.HasMany(d => d.Territories)
                    .WithMany(p => p.Employees)
                    .UsingEntity<Dictionary<string, object>>(
                        "EmployeeTerritory",
                        l => l.HasOne<Territory>().WithMany().HasForeignKey("TerritoryID").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EmployeeTerritories_Territories"),
                        r => r.HasOne<Employee>().WithMany().HasForeignKey("EmployeeID").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EmployeeTerritories_Employees"),
                        j =>
                        {
                            j.HasKey("EmployeeID", "TerritoryID").IsClustered(false);

                            j.ToTable("EmployeeTerritories");

                            j.IndexerProperty<string>("TerritoryID").HasMaxLength(20);
                        });
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToView("Invoices");

                entity.Property(e => e.CustomerID).IsFixedLength();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.CustomerID).IsFixedLength();

                entity.Property(e => e.Freight).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerID)
                    .HasConstraintName("FK_Orders_Customers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_Orders_Employees");

                entity.HasOne(d => d.ShipViaNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipVia)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Orders_Shippers");
            });

            modelBuilder.Entity<Order_Detail>(entity =>
            {
                entity.HasKey(e => new { e.OrderID, e.ProductID })
                    .HasName("PK_Order_Details");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Order_Details)
                    .HasForeignKey(d => d.OrderID)
                    .HasConstraintName("FK_Order_Details_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Order_Details)
                    .HasForeignKey(d => d.ProductID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Details_Products");
            });

            modelBuilder.Entity<Order_Details_Extended>(entity =>
            {
                entity.ToView("Order Details Extended");
            });

            modelBuilder.Entity<Order_Subtotal>(entity =>
            {
                entity.ToView("Order Subtotals");
            });

            modelBuilder.Entity<Orders_Qry>(entity =>
            {
                entity.ToView("Orders Qry");

                entity.Property(e => e.CustomerID).IsFixedLength();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitsInStock).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitsOnOrder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryID)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierID)
                    .HasConstraintName("FK_Products_Suppliers");
            });

            modelBuilder.Entity<Product_Sales_for_1997>(entity =>
            {
                entity.ToView("Product Sales for 1997");
            });

            modelBuilder.Entity<Products_Above_Average_Price>(entity =>
            {
                entity.ToView("Products Above Average Price");
            });

            modelBuilder.Entity<Products_by_Category>(entity =>
            {
                entity.ToView("Products by Category");
            });

            modelBuilder.Entity<Quarterly_Order>(entity =>
            {
                entity.ToView("Quarterly Orders");

                entity.Property(e => e.CustomerID).IsFixedLength();
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionID)
                    .IsClustered(false);

                entity.Property(e => e.RegionID).ValueGeneratedNever();

                entity.Property(e => e.RegionDescription).IsFixedLength();
            });

            modelBuilder.Entity<Sales_Totals_by_Amount>(entity =>
            {
                entity.ToView("Sales Totals by Amount");
            });

            modelBuilder.Entity<Sales_by_Category>(entity =>
            {
                entity.ToView("Sales by Category");
            });

            modelBuilder.Entity<Summary_of_Sales_by_Quarter>(entity =>
            {
                entity.ToView("Summary of Sales by Quarter");
            });

            modelBuilder.Entity<Summary_of_Sales_by_Year>(entity =>
            {
                entity.ToView("Summary of Sales by Year");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.HasKey(e => e.TerritoryID)
                    .IsClustered(false);

                entity.Property(e => e.TerritoryDescription).IsFixedLength();

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Territories)
                    .HasForeignKey(d => d.RegionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Territories_Region");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
