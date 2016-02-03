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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: Api/Test
        public ActionResult Get()
        {
            var categories = _categoryService.GetAll();

            var data = Mapper.Map<List<Category>, List<CategoryModel>>(categories);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Post(CategoryModel category)
        {
            var m = Mapper.Map<CategoryModel, Category>(category);
            _categoryService.AddCategory(m);
        }
    }
}