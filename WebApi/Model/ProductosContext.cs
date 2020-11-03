using Microsoft.EntityFrameworkCore;

namespace WebApi.Model
{
    public class ProductosContext : DbContext
    {

        
        public ProductosContext(DbContextOptions<ProductosContext> options) : base(options)
        {
        }

        public DbSet<Producto> Products { get; set; }
    }
}
