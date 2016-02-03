using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Data;
using WebStore.Core.Domain;

namespace WebStore.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _productRepository.Insert(product);
        }


        public List<Product> GetAll()
        {
            return _productRepository.Table.ToList();
        }
    }
}
