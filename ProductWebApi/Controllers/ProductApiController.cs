using ProductWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebApi.Controllers
{
    public class ProductApiController : ApiController
    {
        public IHttpActionResult Get()
        {
            IList<Product> products = new List<Product>();

            //if connected to db...foreach(Product product in db.Products){products.Add(...)}
            products.Add(new Product() { SKU = "A00001", Name = "Coffee Mug", Inventory = 25, Price = 7.99m, ImgPath = "https://static.pexels.com/photos/271/coffee-cup-mug-drink-medium.jpg" });
            products.Add(new Product() { SKU = "A00002", Name = "Import Beer", Inventory = 25, Price = 8.79m, ImgPath = "https://static.pexels.com/photos/9072/wood-light-alcohol-drink-medium.jpg" });
            products.Add(new Product() { SKU = "A00003", Name = "Rubik's Cube", Inventory = 25, Price = 4.87m, ImgPath = "https://static.pexels.com/photos/19677/pexels-photo-medium.jpg" });
            products.Add(new Product() { SKU = "A00004", Name = "Birthday Ballons", Inventory = 25, Price = 12.22m, ImgPath = "https://static.pexels.com/photos/42067/air-balloon-balloons-birthday-42067-medium.jpeg" });
            products.Add(new Product() { SKU = "A00005", Name = "Fresh Kale", Inventory = 25, Price = 3.24m, ImgPath = "https://static.pexels.com/photos/4694/salad-texture-green-kale-medium.jpg" });

            return Ok<IList<Product>>(products);
        }
    }
}
