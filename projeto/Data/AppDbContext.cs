using Microsoft.EntityFrameworkCore;
using Xablau.Models;

namespace Xablau.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Personagem> XablauDB {get; set;}

        //   public DbSet<Personagem> Personagens { get; set; }
        // public DbSet<Obra> Obras { get; set; }
        // public DbSet<Engenheiro> Engenheiros { get; set; }
        // public DbSet<Material> Materiais { get; set; }
        // public DbSet<Equipamento> Equipamentos { get; set; }
        // public DbSet<Manutencao> Manutencoes { get; set; }
        // public DbSet<Status> StatusObras { get; set; }
        // public DbSet<TipoManutencao> TiposManutencao { get; set; }
        // public DbSet<Usuario> Usuarios { get; set; }
    }
}