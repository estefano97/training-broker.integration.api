using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace training_broker.integration.infrastructure.Database;

public partial class TrainingBrokerContext : DbContext
{
    public TrainingBrokerContext()
    {
    }

    public TrainingBrokerContext(DbContextOptions<TrainingBrokerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Fecha> Fechas { get; set; }

    public virtual DbSet<Industria> Industrias { get; set; }

    public virtual DbSet<RegistroVariacionStockEmpresa> RegistroVariacionStockEmpresas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=kali123_; Trusted_Connection=False; TrustServerCertificate=True; User=kali123_; Password=Kali123!");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Empresas_PK");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Image)
                .HasMaxLength(300)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Fecha>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Fechas_PK");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Fecha1)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Industria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Industrias_PK");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(300)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<RegistroVariacionStockEmpresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("RegistroVariacionStockEmpresa_PK");

            entity.ToTable("RegistroVariacionStockEmpresa");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ActualizacionDeInfoFinanciera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Dpyield)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("DPYield");
            entity.Property(e => e.Emisor)
                .HasMaxLength(300)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("emisor");
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("fecha");
            entity.Property(e => e.IndiceRotacion).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Industria)
                .HasMaxLength(300)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("industria");
            entity.Property(e => e.PrecioUltimasSemanasAlto).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.PrecioUltimasSemanasBajo).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.PrecioUnitarioVeces).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.PresenciaBursatil)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Pvl)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("PVL");
            entity.Property(e => e.UltimoPrecio).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ValorCapMilesUsd)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("ValorCapMilesUSD");
            entity.Property(e => e.ValorNominalUnitario).HasColumnType("decimal(38, 4)");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.RegistroVariacionStockEmpresas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RegistroVariacionStockEmpresa_FK_1");

            entity.HasOne(d => d.IdFechaNavigation).WithMany(p => p.RegistroVariacionStockEmpresas)
                .HasForeignKey(d => d.IdFecha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RegistroVariacionStockEmpresa_FK");

            entity.HasOne(d => d.IdIndustriaNavigation).WithMany(p => p.RegistroVariacionStockEmpresas)
                .HasForeignKey(d => d.IdIndustria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RegistroVariacionStockEmpresa_FK_2");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("NewTable_PK");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Celular)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombres)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Password)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
