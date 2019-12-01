using Microsoft.EntityFrameworkCore;

namespace nodejs_proyectoDos.Models
{
    public partial class RoleContext : DbContext
    { 
        public virtual DbSet<RoleModel> RoleM { get; set; }         
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=vuelos;Username=postgres;Password=1234");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .HasDefaultSchema("public")
            .Entity<RoleModel>()
            .ToTable("roles")
            .HasKey(r => r.roleid);
        }          
    } 
}