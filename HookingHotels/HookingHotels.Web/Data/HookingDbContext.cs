using HookingHotels.Web.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace HookingHotels.Web.Data
{
    public class HookingDbContext : DbContext
    {
        public HookingDbContext(DbContextOptions<HookingDbContext> options) : base(options) { }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reserva>() //EntityTypeBuilder<Reserva>
                .HasOne(r => r.Quarto) //ReferenceNavigationBuilder<Reserva,Quarto>
                .WithMany(q => q.Reservas)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}