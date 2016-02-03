using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Domain;
using WebStore.Core.Tests;
using WebStore.Tests;

namespace WebStore.Data.Tests.PersistanceTests
{
    [TestFixture]
    public class ProductPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_product()
        {
            var product = new Product
            {
                Name = "Name",
                MetaKeywords = "key1",
                Price = 20,
                Description = "Description"
            };

            var fromDb = SaveAndLoadEntity(product);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name");
            fromDb.MetaKeywords.ShouldEqual("key1");
            fromDb.Price.ShouldEqual(20);
            fromDb.Description.ShouldEqual("Description");
        }

        [Test]
        public void Can_save_and_load_product_with_productCategories()
        {
            var product = new Product
            {
                Name = "Name 1",
                MetaKeywords = "key1",
                Price = 20,
                Description = "Description"
            };
            product.ProductCategories.Add
                (
                    new ProductCategory
                    {
                        Category = new Category()
                        {
                            Name = "Books",
                            Description = "Description 1"
                        }
                    }
                );

            var fromDb = SaveAndLoadEntity(product);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");

            fromDb.ProductCategories.ShouldNotBeNull();

            fromDb.ProductCategories.First().Category.ShouldNotBeNull();
            fromDb.ProductCategories.First().Category.Name.ShouldEqual("Books");

        }
    }
}
