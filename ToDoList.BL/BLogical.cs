using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ToDoList.BL
{
    public class BLogical
    {
        public ObservableCollection<Note> Notes { set; get; } = new ObservableCollection<Note>();

        public Note SelectedNote { set; get; }

        public Note EditNote { set; get; } // берем из текстбокса в editnotewindowxaml

        public Note MainNote { set; get; } = new Note();

        public Visibility ButtonPanelVisibility => Notes.Count > 0 ? Visibility.Visible : Visibility.Collapsed;

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(() =>
                {
                    string title = MainNote.Title;
                    if (string.IsNullOrWhiteSpace(title))
                        MessageBox.Show("Поле не может быть пустым!");
                    else
                    {
                        Notes.Add(new Note(title));
                        MainNote.Title = "";
                    }
                }));
            }
        }

        private RelayCommand? removeCommand;
        public RelayCommand RemoveCommand
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
                }));
            }
        }

        private RelayCommand? editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ?? (editCommand = new RelayCommand(() =>
                {
                    if (SelectedNote != null)
                    {
                        SelectedNote.Title = EditNote.Title;
                    }
                }));
            }
        }


        private RelayCommand? openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ?? (openCommand = new RelayCommand(() =>
                {
                    if (SelectedNote != null)
                    {
                        OnEditNoteRequested(this);
                    }
                }));
            }
        }

        public event Action<BLogical>? EditNoteRequested;

        private void OnEditNoteRequested(BLogical noteTitle)
        {
            EditNoteRequested?.Invoke(noteTitle);
        }
    }
}
