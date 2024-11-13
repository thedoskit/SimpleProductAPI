using Microsoft.EntityFrameworkCore;
using SimpleProductAPI.Domain.Models;

namespace SimpleProductAPI.DataAccess
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
