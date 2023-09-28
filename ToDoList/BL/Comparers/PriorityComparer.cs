using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BL
{
    public class PriorityComparer : IComparer<Note>
    {
        public int Compare(Note? x, Note? y)
        {
            var xPriority = x.Priority.PriorityType;
            var yPriority = y.Priority.PriorityType;
            return xPriority.CompareTo(yPriority);
        }
    }
}
