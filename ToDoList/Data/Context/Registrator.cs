using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoList.Data.Context
{
    internal static class Registrator
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContextFactory<TodoDb>(opt => opt.UseNpgsql("Host=localhost;Port=5432;Database=notes;Username=postgres;Password=Misanches2711"));
    }
}
