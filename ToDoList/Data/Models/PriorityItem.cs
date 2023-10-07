using System;

namespace ToDoList.Data.Models
{
    public class PriorityItem : IComparable<ePriorityType>
    {
        public ePriorityType PriorityType { get; set; }

        public PriorityItem(ePriorityType priorityType)
        {
            PriorityType = priorityType;
        }

        public override string ToString()
        {
            return PriorityType.ToString();
        }

        public int CompareTo(ePriorityType other)
        {
            return PriorityType.CompareTo((int)other);
        }
    }
}
