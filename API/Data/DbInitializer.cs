using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>(){
                new Product {
                    Name= "Angular Blue Boots",
                    Description = "very long lorem ipsum about angular description has been created with me!",
                    Price=10000,
                    PictureUrl="/images/products/boot-ang.png",
                    Brand="Angular",
                    Type="Boots",
                    QualityInStock=100
                },
                                new Product {
                    Name= "Angular Blue Boots",
                    Description = "very long lorem ipsum about angular description has been created with me!",
                    Price=10000,
                    PictureUrl="/images/products/boot-ang.png",
                    Brand="Angular",
                    Type="Boots",
                    QualityInStock=100
                },
                                new Product {
                    Name= "Angular Blue Boots",
                    Description = "very long lorem ipsum about angular description has been created with me!",
                    Price=10000,
                    PictureUrl="/images/products/boot-ang.png",
                    Brand="Angular",
                    Type="Boots",
                    QualityInStock=100
                }
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}