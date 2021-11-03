using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Finding_a_Tournament.Domain.Entities
{
    public partial class Finding_a_TournamentContext : DbContext
    {
        public Finding_a_TournamentContext()
        {
        }

        public Finding_a_TournamentContext(DbContextOptions<Finding_a_TournamentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<ServiciosClub> ServiciosClubs { get; set; }
        public virtual DbSet<Torneo> Torneos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=Finding_a_Tournament");
            }*/
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=LAPTOP-712M2JUF;Initial Catalog=Finding_a_Tournament;User ID=sa;password=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasKey(e => e.IdClub);

                entity.ToTable("Club");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Logotipo).IsRequired();

                entity.Property(e => e.NombreClub)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TelefonoContacto)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ServiciosClub>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK_Club_Servicio");

                entity.ToTable("ServiciosClub");

                entity.Property(e => e.Diciplina)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.HorarioDiciplina)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Torneo>(entity =>
            {
                entity.HasKey(e => e.IdTorneo);

                entity.ToTable("Torneo");

                entity.Property(e => e.NombreTorneo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TipoTorneo)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
