using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebApi.Models
{
    public class Product
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
    }
}