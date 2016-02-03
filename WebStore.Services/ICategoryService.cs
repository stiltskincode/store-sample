using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Domain;

namespace WebStore.Services
{
    public interface ICategoryService
    {
        void AddCategory(Category m);

        List<Category> GetAll();
    }
}
