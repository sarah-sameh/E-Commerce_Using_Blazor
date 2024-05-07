using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class ProductService
    {
        private List<Product> products;


        public ProductService()
        {

            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Phone", Price = 1099, Description = "A high-quality smartphone with advanced features", CatId = 1, Image="Phone.jpg" },
                new Product { Id = 6, Name = "Shoes", Price = 1579, Description = "Stylish and comfortable shoes suitable for various occasions.", CatId = 2,Image="sh.jpg" },
                new Product { Id = 2, Name = "Camera", Price = 2049, Description = "A professional-grade camera capable of capturing stunning photos and videos", CatId = 1,Image="Cam.png" },
                new Product { Id = 4, Name = "T-shirt", Price = 1579, Description = "A comfortable and trendy t-shirt made from premium materials.", CatId = 2 ,Image="shirt.jpg"},
                new Product { Id = 3, Name = "Watch", Price = 1579, Description = "A stylish and functional wristwatch with various useful features.", CatId = 1,Image="Watch.png" },
                new Product { Id = 5, Name = "Bag", Price = 1579, Description = "A spacious and durable bag ideal for carrying essentials during travel or daily use.", CatId = 2,Image="bag.png" },

            };


        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

    }


}
