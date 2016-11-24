using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopProductUpdaterService.Models
{
    public class Category
    {
        public int ExternalID { get; set; }
        public string Name { get; set; }
        public int ExternalParentID { get; set; }
    }
}