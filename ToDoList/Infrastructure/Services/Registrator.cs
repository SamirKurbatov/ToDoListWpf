using Microsoft.Extensions.DependencyInjection;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    internal static class Registrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
            => services.AddTransient<IUserDialog, AppWindowUserDialogService>()
            .AddScoped(typeof(IRepository<>), typeof(DbRepository<>))
            .AddScoped<INotesManager, NotesManager>();
    }
}
