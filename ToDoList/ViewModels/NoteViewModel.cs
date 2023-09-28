using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ToDoList.BL;
using ToDoList.Domain;

namespace ToDoList
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        #region Propereties
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

        private ObservableCollection<Note> notes = new();
        public ObservableCollection<Note> Notes
        {
            get => notes;
            set
            {
                notes = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<PriorityItem> PriorityOptions { get; set; } = new()
        {
            new PriorityItem(ePriorityType.Low),
            new PriorityItem(ePriorityType.Medium),
            new PriorityItem(ePriorityType.High)
        };
        #endregion

        public NoteViewModel()
        {
            Notes = GetDefaultNotes();
        }

        #region Commands

        private ICommand? addCommand;
        public ICommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(() =>
                {
                    var title = MainNote.Title;
                    var priority = SelectedPriority;
                    if (!string.IsNullOrWhiteSpace(title) && priority is not null)
                    {
                        MainNote.Priority = priority;
                        Notes.Add(new Note(title, MainNote.Priority));
                        MainNote.Title = "";
                    }
                    else
                    {
                        MessageBox.Show("Проверьте все поля!");
                    }
                }));
            }
        }

        private ICommand? removeCommand;
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
                        var page = new EditNoteWindow(this);
                        var result = page.ShowDialog();
                        if (result == true)
                        {
                            SelectedNote.Priority = page.EditNode.Priority;
                            SelectedNote.Title = page.EditNode.Title;
                        }
                    }
                }, () => Notes.Count > 0));
            }
        }

        private ICommand? orderByPriority;
        public ICommand OrderByPriority
        {
            get
            {
                return orderByPriority ?? (orderByPriority = new RelayCommand(() =>
                {
                    var filtredNotes = Notes
                        .OrderBy((x => x), new PriorityComparer());
                    Notes = new ObservableCollection<Note>(filtredNotes);
                }));
            }
        }

        private ICommand? orderByDate;
        public ICommand OrderByDate
        {
            get
            {
                return orderByDate ?? (orderByDate = new RelayCommand(() =>
                {
                    var filtredNotes = Notes.OrderByDescending(x => x.Date);
                    Notes = new ObservableCollection<Note>(filtredNotes);
                }));
            }
        }

        private ICommand? orderByTitle;
        public ICommand OrderByTitle
        {
            get
            {
                return orderByTitle ?? (orderByTitle = new RelayCommand(() =>
                {
                    var filtredNotes = Notes.OrderBy(x => x.Title);
                    Notes = new ObservableCollection<Note>(filtredNotes);
                }));
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
