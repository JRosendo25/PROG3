using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_de_cine.Data;

public partial class PelisplusContext : DbContext
{
    public PelisplusContext()
    {
    }

    public PelisplusContext(DbContextOptions<PelisplusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pelicula> Peliculas { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.PeliculaId).HasName("PK__Pelicula__C5BC7D109C29869C");

            entity.Property(e => e.PeliculaId).HasColumnName("Pelicula_id");
            entity.Property(e => e.GeneroPelicula)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Genero_pelicula");
            entity.Property(e => e.NombrePelicula)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Nombre_pelicula");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
