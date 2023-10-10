using Microsoft.Extensions.DependencyInjection;
using ToDoList.Data.Entities;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    internal static class Registrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
            => services.AddTransient<IUserDialog, AppWindowUserDialogService>()
            .AddScoped<IRepository<Note>, NotesRepository>()
            .AddScoped<IRepository<Category>, CategoriesRepository>()
            .AddScoped<INotesManager, NotesManager>();
    }
}
