using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopProductUpdaterService.Models
{
    public class Product
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int ExternalCategoryID { get; set; }
    }
}