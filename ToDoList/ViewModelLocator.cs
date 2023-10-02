using Microsoft.Extensions.DependencyInjection;

namespace ToDoList;

public class ViewModelLocator
{
    public MainViewModel MainModel => App.Services.GetRequiredService<MainViewModel>();
}
