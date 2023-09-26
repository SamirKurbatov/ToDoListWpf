using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ToDoList.Domain;

namespace ToDoList
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public PriorityItem SelectedPriority { set; get; }

        private Note selectedNote;
        public Note SelectedNote
        {
            get => selectedNote;
            set
            {
                selectedNote = value;
                OnPropertyChanged();
            }
        }

        public Note MainNote { set; get; } = new Note();

        public ObservableCollection<Note> Notes { set; get; } = new();

        public NoteViewModel()
        {
            Notes = GetDefaultNotes();
        }

        public ObservableCollection<PriorityItem> PriorityOptions { get; set; } = new()
        {
            new PriorityItem(ePriorityType.Low),
            new PriorityItem(ePriorityType.Medium),
            new PriorityItem(ePriorityType.High)
        };

        #region Commands


        private ICommand? addCommand;
        public ICommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(() =>
                {
                    var title = MainNote.Title;
                    MainNote.Priority = SelectedPriority;
                    Notes.Add(new Note(title, MainNote.Priority));
                    MainNote.Title = "";
                }));
            }
        }

        private ICommand removeCommand;
        public ICommand RemoveCommand
        {
            get
            {
                return removeCommand ?? (removeCommand = new RelayCommand(() =>
                {
                    if (SelectedNote != null)
                    {
                        Notes.Remove(SelectedNote);
                    }
                    else
                    {
                        MessageBox.Show("Элемент не выбран! ");
                    }
                }, () => Notes.Count > 0));
            }
        }

        private ICommand? openCommand;
        public ICommand OpenCommand
        {
            get
            {
                return openCommand ?? (openCommand = new RelayCommand(() =>
                {
                    if (SelectedNote != null)
                    {
                        var page = new EditNoteWindow();
                        var result = page.ShowDialog();
                        if (result == true)
                        {
                            SelectedNote.Title = page.EditNode.Title;
                        }
                    }
                }, () => Notes.Count > 0));
            }
        }
        #endregion

        private ObservableCollection<Note> GetDefaultNotes()
        {
            Notes.Add(new Note("Default", new PriorityItem(ePriorityType.Low)));
            Notes.Add(new Note("Default", new PriorityItem(ePriorityType.Medium)));
            Notes.Add(new Note("Default", new PriorityItem(ePriorityType.High)));

            return Notes;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
