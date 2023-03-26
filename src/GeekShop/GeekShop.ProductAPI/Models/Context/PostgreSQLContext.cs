using Microsoft.EntityFrameworkCore;

namespace GeekShop.ProductAPI.Models.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext() { }
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}
