using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.Core.Domain;
using WebStore.Core.Infrastructure;
using WebStore.Web.Areas.Api.Models;

namespace WebStore.Web.Bootstrapper
{
    public class AutoMapperStartupTask : IStartupTask
    {
        public void Execute()
        {
            Mapper.CreateMap<CategoryModel, Category>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            Mapper.CreateMap<Category, CategoryModel>();

            Mapper.CreateMap<ProductModel, Product>()
                .ForMember(dest => dest.ProductCategories, opt => opt.Ignore());

            Mapper.CreateMap<Product, ProductModelResponse>()
                .ForMember(dest => dest.Categories, opt => opt.Ignore());

        }

        public int Order
        {
            get { return 0; }
        }
    }
}