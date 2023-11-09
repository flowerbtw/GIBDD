using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace itogovoe_gibdd.Database;

public partial class ItogovoeGibddContext : DbContext
{
    public ItogovoeGibddContext()
    {
    }

    public ItogovoeGibddContext(DbContextOptions<ItogovoeGibddContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DriversCards> DriversCards { get; set; }

    public virtual DbSet<DriversLicenses> DriversLicenses { get; set; }

    public virtual DbSet<Penalties> Penalties { get; set; }

    public virtual DbSet<Profiles> Profiles { get; set; }

    public virtual DbSet<RoadAccidents> RoadAccidents { get; set; }

    public virtual DbSet<Venichles> Venichles { get; set; }

    string basePath = AppDomain.CurrentDomain.BaseDirectory;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite($"Data Source={basePath}itogovoe_gibdd.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DriversCards>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("GUID");
        });

        modelBuilder.Entity<DriversLicenses>(entity =>
        {
            entity.HasKey(e => e.Number);

            entity.HasOne(d => d.OwnerNavigation).WithMany(p => p.DriversLicenses).HasForeignKey(d => d.Owner);
        });

        modelBuilder.Entity<Penalties>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("GUID");

            entity.HasOne(d => d.RecipientNavigation).WithMany(p => p.Penalties).HasForeignKey(d => d.Recipient);
        });

        modelBuilder.Entity<Profiles>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("GUID");
        });

        modelBuilder.Entity<RoadAccidents>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("GUID");

            entity.HasOne(d => d.CulpritNavigation).WithMany(p => p.RoadAccidentCulpritNavigations).HasForeignKey(d => d.Culprit);

            entity.HasOne(d => d.VictimNavigation).WithMany(p => p.RoadAccidentVictimNavigations).HasForeignKey(d => d.Victim);
        });

        modelBuilder.Entity<Venichles>(entity =>
        {
            entity.HasKey(e => e.Vin);

            entity.Property(e => e.Vin).HasColumnName("VIN");

            entity.HasOne(d => d.OwnerNavigation).WithMany(p => p.Venichles).HasForeignKey(d => d.Owner);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
