using Microsoft.Extensions.DependencyInjection;

namespace ToDoList
{
    internal static class Registrator
    {
        public static void AddViewModels(this IServiceCollection services)
            => services.AddScoped<MainViewModel>();
    }
}
