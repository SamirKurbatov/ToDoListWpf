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
        }

        public static List<Note> Notes { get; }

        public static List<PriorityItem> PriorityItems { get; }
    }
}
