namespace ToDoList.Domain
{
    public class PriorityItem
    {
        public string Name { get; set; }

        public PriorityItem(PriorityType name)
        {
            Name = name.ToString();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
