using Microsoft.EntityFrameworkCore;
using DbContextDirect.Models;

namespace DbContextDirect.Data
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}