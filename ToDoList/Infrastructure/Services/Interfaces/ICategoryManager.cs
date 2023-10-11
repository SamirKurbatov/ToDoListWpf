using ToDoList.Data.Entities;

namespace ToDoList.Infrastructure.Services.Interfaces
{
    public interface ICategoryManager
    {
        IRepository<Category> CategoriesRepo { get; }

        public Category AddCategory(int id, string name);

        public bool Remove(Category category);
    }
}
