using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Entities;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    internal class CategoryManager : ICategoryManager
    {
        public IRepository<Category> CategoriesRepo { get; }

        public CategoryManager(IRepository<Category> categoriesRepo)
        {
            CategoriesRepo = categoriesRepo;
        }

        public Category AddCategory(int id, string name)
        {
            var category = new Category()
            {
                Id = id,
                Name = name,
            };

            CategoriesRepo.Add(category);

            return category;
        }

        public Category ChangeCategoryName(Category category, string name)
        {
            category.Name = name;

            return CategoriesRepo.Update(category);
        }

        public bool Remove(Category category) =>
            category is null
            ? throw new ArgumentNullException(nameof(category))
            : CategoriesRepo.Remove(category.Id);
    }
}
