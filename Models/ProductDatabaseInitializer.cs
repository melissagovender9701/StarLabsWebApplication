using System.Collections.Generic;
using System.Data.Entity;

namespace StarLabsClothingStore.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Shirts"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Pants"
                }
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "T-shirt",
                    Description = "This is a small T-shirt",
                    ImagePath="tshirt_small.png",
                    UnitPrice = 10.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "T-shirt",
                    Description = "This is a medium T-shirt",
                    ImagePath="tshirt_medium.png",
                    UnitPrice = 20.00,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "T-shirt",
                    Description = "This is a large T-shirt",
                    ImagePath="tshirt_large.png",
                    UnitPrice = 30.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Golfer",
                    Description = "This is a small Golfer",
                    ImagePath="golfer_small.png",
                    UnitPrice = 20.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Golfer",
                    Description = "This is a medium Golfer",
                    ImagePath="golfer_medium.png",
                    UnitPrice = 40.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Golfer",
                    Description = "This is a large Golfer",
                    ImagePath="golfer_large.png",
                    UnitPrice = 60.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Jeans",
                    Description = "This is small Jeans",
                    ImagePath="jeans_small.png",
                    UnitPrice = 10.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Jeans",
                    Description = "This is medium Jeans",
                    ImagePath="jeans_medium.png",
                    UnitPrice = 20.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Jeans",
                    Description = "This is large Jeans",
                    ImagePath="jeans_large.png",
                    UnitPrice = 30.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Formal Pants",
                    Description = "This is small Formal Pants",
                    ImagePath="formal_brown.png",
                    UnitPrice = 40.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Formal Pants",
                    Description = "This is medium Formal Pants",
                    ImagePath="formal_blue.png",
                    UnitPrice = 50.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Formal Pants",
                    Description = "This is large Formal Pants",
                    ImagePath="formal_red.png",
                    UnitPrice = 60.00,
                    CategoryID = 2
                }
            };
            return products;
        }
    }
}