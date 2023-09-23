﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace ToDoList.BL
{
    public class BLogical
    {
        public ObservableCollection<Note> Notes { set; get; } = new ObservableCollection<Note>();

        public Note SelectedNote { set; get; }

        public Note MainNote { set; get; } = new Note();

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

        private RelayCommand? openCommand;
        public RelayCommand OpenCommand
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
                }));
            }
        }
    }
}
