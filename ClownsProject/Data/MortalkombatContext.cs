using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ClownsProject.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ClownsProject;

public partial class MortalkombatContext : DbContext
{
    public MortalkombatContext()
    {
    }

    public MortalkombatContext(DbContextOptions<MortalkombatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("config.json");
        var config = builder.Build();
        string connectionString = config.GetConnectionString("DefaultConnection");
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        optionsBuilder.UseMySql(connectionString, Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.35-mysql"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.TradeMark).HasName("PRIMARY");

            entity.ToTable("company");

            entity.Property(e => e.TradeMark)
                .HasMaxLength(50)
                .HasColumnName("Trade_mark");
            entity.Property(e => e.Password).HasMaxLength(30);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.IdProject).HasName("PRIMARY");

            entity.ToTable("project");

            entity.HasIndex(e => e.Login, "Login");

            entity.HasIndex(e => e.TradeMark, "Trade_mark");

            entity.Property(e => e.IdProject).HasColumnName("ID_project");
            entity.Property(e => e.Login).HasMaxLength(30);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.TradeMark)
                .HasMaxLength(50)
                .HasColumnName("Trade_mark");

            entity.HasOne(d => d.LoginNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.Login)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("project_ibfk_1");

            entity.HasOne(d => d.TradeMarkNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.TradeMark)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("project_ibfk_2");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.Property(e => e.IdRole).HasColumnName("ID_role");
            entity.Property(e => e.Title).HasMaxLength(20);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("status");

            entity.Property(e => e.IdStatus).HasColumnName("ID_status");
            entity.Property(e => e.Title).HasMaxLength(20);
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.IdTask).HasName("PRIMARY");

            entity.ToTable("task");

            entity.HasIndex(e => e.IdProject, "ID_project");

            entity.HasIndex(e => e.IdStatus, "ID_status");

            entity.HasIndex(e => e.Login, "Login");

            entity.Property(e => e.IdTask).HasColumnName("ID_task");
            entity.Property(e => e.DateEnd).HasColumnName("Date_end");
            entity.Property(e => e.DateStart).HasColumnName("Date_start");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdProject).HasColumnName("ID_project");
            entity.Property(e => e.IdStatus).HasColumnName("ID_status");
            entity.Property(e => e.Login).HasMaxLength(30);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.IdProjectNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdProject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("task_ibfk_3");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("task_ibfk_2");

            entity.HasOne(d => d.LoginNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.Login)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("task_ibfk_1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Login).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.Brand, "Brand");

            entity.HasIndex(e => e.IdRole, "ID_role");

            entity.Property(e => e.Login).HasMaxLength(30);
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.IdRole).HasColumnName("ID_role");
            entity.Property(e => e.Passwords).HasMaxLength(30);
            entity.Property(e => e.PhoneNumber).HasMaxLength(11);

            entity.HasOne(d => d.BrandNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Brand)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_ibfk_1");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
