using System.Linq;
using ToDoList.Data.Entities.Base;

namespace ToDoList.Infrastructure.Services.Interfaces;

internal interface IRepository<T> where T : Entity
{
    IQueryable<T> Items { get; }

    T Get(int id);

    T Add(T item);

    T Update(T item);

    bool Remove(int id);
}
