using Microsoft.EntityFrameworkCore;

namespace EXAMEN.Controllers.Model
{
    public class app_context : DbContext
    {
        public app_context(DbContextOptions<app_context> options) : base(options)
        { }

        public DbSet<Eveniment> Evenimente { get; set; }
        public DbSet<Participant> Participant { get; set; }
        public DbSet<Participare> Participari { get; set; }
        public DbSet<Clasa3> Clasa3 { get; set; }
        public DbSet<Clasa2> Clasa2 { get; set; }
        public DbSet<Clasa1> Clasa1 { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurarea relației many-to-many între Eveniment și Participant
            modelBuilder.Entity<Participare>()
                .HasKey(p => new { p.EvenimentId, p.ParticipantId });

            modelBuilder.Entity<Participare>()
                .HasOne(p => p.Eveniment)
                .WithMany(e => e.Participari)
                .HasForeignKey(p => p.EvenimentId);

            modelBuilder.Entity<Participare>()
                .HasOne(p => p.Participant)
                .WithMany(p => p.Participari)
                .HasForeignKey(p => p.ParticipantId);

            // Alte configurări pentru Clasa3 (dacă este nevoie)

            base.OnModelCreating(modelBuilder);
        }
    }
}
