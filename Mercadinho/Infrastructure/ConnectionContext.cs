using Mercadinho.Model;
using Microsoft.EntityFrameworkCore;

namespace Mercadinho.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options){}
        public DbSet<Product> Products { get; set; }
    }
}
