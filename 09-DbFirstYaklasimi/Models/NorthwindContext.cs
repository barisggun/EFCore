using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext()
    {
    }

    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeTrigger> EmployeeTriggers { get; set; }

    public virtual DbSet<Kategoriler> Kategorilers { get; set; }

    public virtual DbSet<KitapKategorileri> KitapKategorileris { get; set; }

    public virtual DbSet<Kitaplar> Kitaplars { get; set; }

    public virtual DbSet<LogCustomer> LogCustomers { get; set; }

    public virtual DbSet<MyUser> MyUsers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SuppliersTrigger> SuppliersTriggers { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    public virtual DbSet<TestTablosu> TestTablosus { get; set; }

    public virtual DbSet<Testo> Testos { get; set; }

    public virtual DbSet<UrunKategorileri33> UrunKategorileri33s { get; set; }

    public virtual DbSet<Yazarlar> Yazarlars { get; set; }

    public virtual DbSet<YeniTedarikciler> YeniTedarikcilers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=LAPTOP-TKFJC4RO\\SQLEXPRESS;database=Northwind;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("trigger_CustomerDeleted");
                    tb.HasTrigger("trigger_CustomerUpdated");
                });

            entity.Property(e => e.CustomerId).IsFixedLength();

            entity.HasMany(d => d.CustomerTypes).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerCustomerDemo",
                    r => r.HasOne<CustomerDemographic>().WithMany()
                        .HasForeignKey("CustomerTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CustomerCustomerDemo"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CustomerCustomerDemo_Customers"),
                    j =>
                    {
                        j.HasKey("CustomerId", "CustomerTypeId").IsClustered(false);
                        j.ToTable("CustomerCustomerDemo");
                        j.IndexerProperty<string>("CustomerId")
                            .HasMaxLength(5)
                            .IsFixedLength()
                            .HasColumnName("CustomerID");
                        j.IndexerProperty<string>("CustomerTypeId")
                            .HasMaxLength(10)
                            .IsFixedLength()
                            .HasColumnName("CustomerTypeID");
                    });
        });

        modelBuilder.Entity<CustomerDemographic>(entity =>
        {
            entity.HasKey(e => e.CustomerTypeId).IsClustered(false);

            entity.Property(e => e.CustomerTypeId).IsFixedLength();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("UlkeYoksaGuncelle"));

            entity.HasOne(d => d.ReportsToNavigation).WithMany(p => p.InverseReportsToNavigation).HasConstraintName("FK_Employees_Employees");

            entity.HasMany(d => d.Territories).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeTerritory",
                    r => r.HasOne<Territory>().WithMany()
                        .HasForeignKey("TerritoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeTerritories_Territories"),
                    l => l.HasOne<Employee>().WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeTerritories_Employees"),
                    j =>
                    {
                        j.HasKey("EmployeeId", "TerritoryId").IsClustered(false);
                        j.ToTable("EmployeeTerritories");
                        j.IndexerProperty<int>("EmployeeId").HasColumnName("EmployeeID");
                        j.IndexerProperty<string>("TerritoryId")
                            .HasMaxLength(20)
                            .HasColumnName("TerritoryID");
                    });
        });

        modelBuilder.Entity<EmployeeTrigger>(entity =>
        {
            entity.Property(e => e.PersonelId).ValueGeneratedNever();
            entity.Property(e => e.TotalOrderAmount).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<KitapKategorileri>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitapKategorileri_Kategoriler");

            entity.HasOne(d => d.Kategori).WithMany().HasConstraintName("FK_KitapKategorileri_Kitaplar");
        });

        modelBuilder.Entity<Kitaplar>(entity =>
        {
            entity.HasOne(d => d.YazarNavigation).WithMany(p => p.Kitaplars).HasConstraintName("FK_Kitaplar_Yazarlar");
        });

        modelBuilder.Entity<LogCustomer>(entity =>
        {
            entity.Property(e => e.CustomerId).IsFixedLength();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.CustomerId).IsFixedLength();
            entity.Property(e => e.Freight).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Customers");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Employees");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Shippers");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PK_Order_Details");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("StokMiktariniAzalt");
                    tb.HasTrigger("UrunStokMiktariniGuncelle");
                    tb.HasTrigger("UrunStokMiktariniGuncelle_Delete");
                    tb.HasTrigger("tr_InsertOrderDetails");
                });

            entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");
            entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");
            entity.Property(e => e.UnitsInStock).HasDefaultValueSql("((0))");
            entity.Property(e => e.UnitsOnOrder).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasConstraintName("FK_Products_Categories");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products).HasConstraintName("FK_Products_Suppliers");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).IsClustered(false);

            entity.Property(e => e.RegionId).ValueGeneratedNever();
            entity.Property(e => e.RegionDescription).IsFixedLength();
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("trg_SuppliersChanges"));
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.HasKey(e => e.TerritoryId).IsClustered(false);

            entity.Property(e => e.TerritoryDescription).IsFixedLength();

            entity.HasOne(d => d.Region).WithMany(p => p.Territories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Territories_Region");
        });

        modelBuilder.Entity<TestTablosu>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
