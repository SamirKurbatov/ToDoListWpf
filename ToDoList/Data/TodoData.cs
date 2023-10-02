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
                new Note("Default", PriorityItems.FirstOrDefault()),
                    new Note("Default", PriorityItems.FirstOrDefault()),
                        new Note("Default", PriorityItems.FirstOrDefault()),
                            new Note("Default", PriorityItems.FirstOrDefault()),
                                new Note("Default", PriorityItems.FirstOrDefault()),
                                    new Note("Default", PriorityItems.FirstOrDefault()),
                                        new Note("Default", PriorityItems.FirstOrDefault()),
                                            new Note("Default", PriorityItems.FirstOrDefault()),
                                new Note("Default", PriorityItems.FirstOrDefault()),
                                new Note("Default", PriorityItems.FirstOrDefault()),
                                new Note("Default", PriorityItems.FirstOrDefault()),
                new Note("Default", PriorityItems.Skip(1).FirstOrDefault()),
                new Note("Default", PriorityItems.Skip(2).FirstOrDefault()),
            };
        }

        public static List<Note> Notes { get;}

        public static List<PriorityItem> PriorityItems { get; }
    }
}
