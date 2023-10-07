using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    static class TodoData
    {
        static TodoData()
        {
            PriorityItems = new()
            {
                new PriorityItem(ePriorityType.Low),
                new PriorityItem(ePriorityType.Medium),
                new PriorityItem(ePriorityType.High)
            };

            Groups = new()
            {
                new Group("Бытовые дела",new List<Note>
                {
                    new Note("Пропылесосить", new PriorityItem(ePriorityType.Medium)),
                    new Note("Пропылесоситsь", new PriorityItem(ePriorityType.Medium)),
                    new Note("Пропылесоситsaaь", new PriorityItem(ePriorityType.Medium)),
                    new Note("Пропылесоситsaaьfdfd", new PriorityItem(ePriorityType.Medium)),
                }),

                new Group("Прогаммирование",new List<Note>
                {
                    new Note("Сделать пет-проект", new PriorityItem(ePriorityType.Medium)),
                    new Note("Литкод", new PriorityItem(ePriorityType.High)),
                }),
            };
        }

        public static List<Note> Notes { get; }

        public static List<Group> Groups { get; }

        public static List<PriorityItem> PriorityItems { get; }
    }
}
