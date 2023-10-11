using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Data.Entities;
using ToDoList.Infrastructure;

namespace ToDoList
{
    public class EditGroupViewModel : ViewModel
    {

        public EditGroupViewModel(Category category, IEnumerable<Category> categories)
        {
            this.category = category;
            Categories = categories;
        }

        private readonly Dictionary<string, object> Values = new();

        public EventHandler<EventArgs<bool>> ClosedDialog;

        private readonly Category category;

        public string Name
        {
            get => GetValue(category.Name);
            set => SetValue(value);
        }

        public IEnumerable<Category> Categories { get; }

        private T GetValue<T>(T value, [CallerMemberName] string propName = "")
        {
            if (Values.TryGetValue(propName, out var oldVal) && Equals(value, oldVal))
            {
                return (T)value;
            }

            return value;
        }

        private bool SetValue(object value, [CallerMemberName] string propName = "")
        {
            if (Values.TryGetValue(propName, out var oldVal) && Equals(value, oldVal))
            {
                return false;
            }
            Values[propName] = value;
            OnPropertyChanged(propName);
            return true;
        }

        private ICommand closeDialogCommand;
        public ICommand CloseDialogCommand
            => closeDialogCommand ??= new LambdaCommand(OnClose);

        private void OnClose(object g)
        {
            var result = g is not null && Convert.ToBoolean(g);
            if (result)
            {
                Commit();
            }
            ClosedDialog?.Invoke(this, result);
        }

        private void Commit()
        {
            var type = category.GetType();
            foreach (var (propName, value) in Values)
            {
                var property = type.GetProperty(propName);
                if (property is not { CanWrite: true })
                    continue;
                property.SetValue(category, value);
            }
        }
    }
}
