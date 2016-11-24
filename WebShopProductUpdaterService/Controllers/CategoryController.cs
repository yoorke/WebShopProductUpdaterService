using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eshopBL;
using WebShopProductUpdaterService.Models;

namespace WebShopProductUpdaterService.Controllers
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult Post([FromBody] Category category)
        {
            int status = new CategoryBL().SaveCategoryFromExternalApplication(category.ExternalID, category.Name, category.ExternalParentID);
            return Ok(status);
        }
    }
}
