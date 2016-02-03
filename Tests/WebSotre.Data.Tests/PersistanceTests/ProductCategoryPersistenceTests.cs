using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Domain;
using WebStore.Core.Tests;
using WebStore.Tests;

namespace WebStore.Data.Tests.PersistanceTests
{
    [TestFixture]
    public class ProductCategoryPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_productCategory()
        {
            var productCategory = new ProductCategory
                {
                    Product = new Product()
                    {
                        Name = "Name 1",
                        Description = "Description 1"
                    },
                    Category = new Category()
                    {
                        Name = "Books",
                        Description = "Description 1"
                    }
                };

            var fromDb =  SaveAndLoadEntity(productCategory);

            fromDb.ShouldNotBeNull();
            fromDb.Product.ShouldNotBeNull();
            fromDb.Product.Name.ShouldEqual("Name 1");

            fromDb.Category.ShouldNotBeNull();
            fromDb.Category.Name.ShouldEqual("Books");
        }
    }
}
