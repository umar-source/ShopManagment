using SM.Business.Models;

namespace SM.Business.DataServices
{
    public class ProductService
    {
      


        public List<ProductModel>  GetAll()
        {
            List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel { Id = 1, Name = "asdv", Description = "igofjdenkfdbv" },
                new ProductModel { Id = 2, Name = "asdv", Description = "igofjdenkfdbv" },
                new ProductModel { Id = 3, Name = "asdv", Description = "igofjdenkfdbv" },
                new ProductModel { Id = 4, Name = "asdv", Description = "igofjdenkfdbv" },
                new ProductModel { Id = 6, Name = "asdv", Description = "igofjdenkfdbv" },
                new ProductModel { Id = 5, Name = "asdv", Description = "igofjdenkfdbv" }
            };

            return products;
        }

     }
}