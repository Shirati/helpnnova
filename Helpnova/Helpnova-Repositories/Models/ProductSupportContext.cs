using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Helpnova_Repositories.Models;

public partial class ProductSupportContext : DbContext
{
    public ProductSupportContext()
    {
    }

    public ProductSupportContext(DbContextOptions<ProductSupportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Procedure> Procedures { get; set; }

    public virtual DbSet<ProcedureCourse> ProcedureCourses { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Product support;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisplayOrder)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.Courses)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Course_Customer");

            entity.HasOne(d => d.Product).WithMany(p => p.Courses)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Course_Product");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Client");

            entity.ToTable("Customer");

            entity.Property(e => e.ContactDetails)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Logo).HasColumnType("image");
        });

        modelBuilder.Entity<Procedure>(entity =>
        {
            entity.ToTable("Procedure");

            entity.Property(e => e.AlternateName).HasMaxLength(50);
            entity.Property(e => e.Explanation).HasMaxLength(50);
            entity.Property(e => e.HowToGetThere).HasMaxLength(50);
            entity.Property(e => e.ImageLink1).HasColumnType("image");
            entity.Property(e => e.ImageLink2).HasColumnType("image");
            entity.Property(e => e.ImageLink3).HasColumnType("image");
            entity.Property(e => e.Keywords)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProcedureName).HasMaxLength(50);
            entity.Property(e => e.SeeMore).HasMaxLength(50);
            entity.Property(e => e.Summary).HasMaxLength(50);
            entity.Property(e => e.Tip).HasMaxLength(50);
            entity.Property(e => e.VideoLink).HasMaxLength(50);

            entity.HasOne(d => d.Customer).WithMany(p => p.Procedures)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Procedure_Customer");

            entity.HasOne(d => d.Product).WithMany(p => p.Procedures)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Procedure_Product");
        });

        modelBuilder.Entity<ProcedureCourse>(entity =>
        {
            entity.ToTable("ProcedureCourse");

            entity.Property(e => e.DisplayOrder)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.ProcedureCourses)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_ProcedureCourse_Course");

            entity.HasOne(d => d.Customer).WithMany(p => p.ProcedureCourses)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ProcedureCourse_Customer");

            entity.HasOne(d => d.Procedure).WithMany(p => p.ProcedureCourses)
                .HasForeignKey(d => d.ProcedureId)
                .HasConstraintName("FK_ProcedureCourse_Procedure");

            entity.HasOne(d => d.Product).WithMany(p => p.ProcedureCourses)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProcedureCourse_Product");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.Products)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Product_Customer");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserLogin);

            entity.ToTable("User");

            entity.Property(e => e.UserLogin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Customer).WithMany(p => p.Users)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_User_Customer");

            entity.HasOne(d => d.Product).WithMany(p => p.Users)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_User_Product");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
