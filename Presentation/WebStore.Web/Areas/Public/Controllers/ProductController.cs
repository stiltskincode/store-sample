using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Services;

namespace WebStore.Web.Areas.Public.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        //ctor
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Public/Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}