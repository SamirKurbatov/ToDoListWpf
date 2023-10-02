using Microsoft.Extensions.DependencyInjection;

namespace ToDoList.ViewModels
{
    internal static class Registrator
    {
        public static void AddViewModels(this IServiceCollection services)
            => services.AddSingleton<MainViewModel>();
    }
}
