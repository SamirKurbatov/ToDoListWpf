using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToDoList.Data.Entities;

namespace ToDoList.Infrastructure.Comparers
{
    public class PriorityComparer : IComparer<Note>
    {
        public int Compare(Note? x, Note? y)
        {
            var xPriority = x.PriorityItem.PriorityType;
            var yPriority = y.PriorityItem.PriorityType;
            return xPriority.CompareTo(yPriority);
        }
    }
}
