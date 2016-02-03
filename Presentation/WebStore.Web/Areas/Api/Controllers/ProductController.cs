using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Core.Domain;
using WebStore.Services;
using WebStore.Web.Areas.Api.Models;

namespace WebStore.Web.Areas.Api.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Get()
        {
            var products = _productService.GetAll();
            var data = Mapper.Map<List<Product>, List<ProductModelResponse>>(products);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Post(ProductModel product)
        {
            var m = Mapper.Map<ProductModel, Product>(product);
            m.ProductCategories.Add(new ProductCategory() { CategoryId = product.Category.Id });
            //_categoryService.AddCategory(m);
            _productService.AddProduct(m);
        }
    }
}