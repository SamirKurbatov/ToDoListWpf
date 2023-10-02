using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList;

public abstract class ViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propName = "") 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

    protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propName = "")
    {
        if (Equals(field, value))
        {
            return false;
        }
        field = value;
        OnPropertyChanged(propName);
        return true;
    }
}
