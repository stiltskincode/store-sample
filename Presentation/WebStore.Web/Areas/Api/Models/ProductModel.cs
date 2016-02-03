using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Web.Areas.Api.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public SelectOptionModel Category { get; set; }
        public string Keywords { get; set; }
    }
}