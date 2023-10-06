using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using ToDoList.Domain;

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

            Notes = new()
            {
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Medium)),
                new Note("Default", new PriorityItem(ePriorityType.High)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
                new Note("Default", new PriorityItem(ePriorityType.Low)),
            };

            GroupNotes = new()
            {
                new Group("Бытовые дела",new List<Note>
                {
                    new Note("Пропылесосить", new PriorityItem(ePriorityType.Medium)),
                }),

                new Group("Прогаммирование",new List<Note>
                {
                    new Note("Сделать пет-проект", new PriorityItem(ePriorityType.Medium)),
                    new Note("Литкод", new PriorityItem(ePriorityType.High)),
                }),
            };
        }

        public static List<Note> Notes { get; }

        public static List<Group> GroupNotes { get; }

        public static List<PriorityItem> PriorityItems { get; }
    }
}
