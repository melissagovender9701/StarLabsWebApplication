using System.Data.Entity;
namespace StarLabsClothingStore.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("StarLabsClothingStore")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
