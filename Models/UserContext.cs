using Microsoft.EntityFrameworkCore;

namespace nodejs_proyectoDos.Models
{
    public partial class UserContext : DbContext
    {
        public virtual DbSet<UserModel> UserM { get; set; }
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=vuelos;Username=postgres;Password=1234");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .HasDefaultSchema("public")
            .Entity<UserModel>()
            .ToTable("usuarios")
            .HasKey(r => r.userid);
        }    
    }
}