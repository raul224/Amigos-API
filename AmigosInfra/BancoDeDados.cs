using AmigosCore;
using Microsoft.EntityFrameworkCore;

namespace AmigosInfra
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions options) : base(options) { }
        public DbSet<Amigo> Amigo { get; set; }
    }
}
