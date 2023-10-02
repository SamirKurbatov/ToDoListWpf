using Microsoft.Extensions.DependencyInjection;

namespace ToDoList.Infrastructure.Services
{
    internal static class Registrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
            => services.AddTransient<IUserDialog, AppWindowUserDialogService>();
    }
}
