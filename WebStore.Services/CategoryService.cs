using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Data;
using WebStore.Core.Domain;

namespace WebStore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void AddCategory(Category m)
        {
                _categoryRepository.Insert(m);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.Table.ToList();
        }
    }
}
