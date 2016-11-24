using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebShopProductUpdaterService.Models;
using eshopBL;
using System.Configuration;

namespace WebShopProductUpdaterService.Controllers
{
    public class ProductController : ApiController
    {
        public IHttpActionResult Post([FromBody] Product product)
        {
            bool insertIfNew = bool.Parse(ConfigurationManager.AppSettings["insertIfNew"]);
            int status = new ProductBL().SaveProductFromExternalApplication(product.Barcode, product.Name, product.Quantity, product.Price, product.ExternalCategoryID, insertIfNew);
            return Ok(status);
        }
    }
}
