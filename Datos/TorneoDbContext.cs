using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TorneoPOO_JOLMEDO.Datos
{
    public class TorneoDbContext : DbContext
    {
        // 1er paso: DbSet para cada clase que se quiere mapear a la base de datos
        public DbSet<Models.Equipo> Equipos { get; set; }
        public DbSet<Models.Jugador> Jugadores { get; set; }
        public DbSet<Models.Partido> Partidos { get; set; }

        // 2do paso: Configurar la cadena de conexión
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AF9QAIJ\SQLEXPRESS;Database=TORNEO_JOLMEDO;User Id=sa;Password=Josueolmedo1234;TrustServerCertificate=True;");
        }

        //3er paso: Configurar las relaciones entre las tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion 1 a muchos entre Equipo y Jugador
            modelBuilder.Entity<Models.Equipo>()
                .HasMany(e => e.Jugadores)
                .WithOne()
                .HasForeignKey(j => j.EquipoId)
                .OnDelete(DeleteBehavior.Cascade);

            //Relacion 1 a muchos entre Partido y Equipo (local y visitante)
            modelBuilder.Entity<Models.Partido>()
                .HasOne(p => p.Local)
                .WithMany()
                .HasForeignKey(p => p.LocalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Models.Partido>()
                .HasOne(p => p.Visitante)
                .WithMany()
                .HasForeignKey(p => p.VisitanteId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
