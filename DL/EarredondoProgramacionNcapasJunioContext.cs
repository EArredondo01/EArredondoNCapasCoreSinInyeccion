using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DL;

public partial class EarredondoProgramacionNcapasJunioContext : DbContext
{
    public EarredondoProgramacionNcapasJunioContext()
    {
    }

    public EarredondoProgramacionNcapasJunioContext(DbContextOptions<EarredondoProgramacionNcapasJunioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Materium> Materia { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Semestre> Semestres { get; set; }

    public virtual DbSet<MateriaGetAllDTO> MateriaGetAllDTO {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; Database=EArredondoProgramacionNCapasJunio; TrustServerCertificate=True; User ID=sa; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MateriaGetAllDTO>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK__Estado__FBB0EDC1DF5092D2");

            entity.ToTable("Estado");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Materium>(entity =>
        {
            entity.HasKey(e => e.IdMateria).HasName("PK__Materia__EC174670972E8B08");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSemestreNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdSemestre)
                .HasConstraintName("FK__Materia__IdSemes__49C3F6B7");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.IdMunicipio).HasName("PK__Municipi__61005978C574B6E7");

            entity.ToTable("Municipio");

            entity.Property(e => e.IdMunicipio).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Municipio__IdEst__38996AB5");
        });

        modelBuilder.Entity<Semestre>(entity =>
        {
            entity.HasKey(e => e.IdSemestre).HasName("PK__Semestre__BD1FD7F80BC47205");

            entity.ToTable("Semestre");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
