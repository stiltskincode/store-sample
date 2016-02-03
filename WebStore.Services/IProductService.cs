using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Domain;

namespace WebStore.Services
{
    public interface IProductService
    {
        void AddProduct(Product m);

        List<Product> GetAll();
    }
}
