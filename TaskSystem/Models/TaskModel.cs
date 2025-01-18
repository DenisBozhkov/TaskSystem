namespace TaskSystem.Models
{
    // Този клас може да се използва като модел за базата данни.
    // Може да добавяш към него, каквото си искаш, включително и атрибути към свойствата
    // - това няма да повлияе на кода, в който го използвам.
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Priority Priority { get; set; }
        public bool IsDone { get; set; }
        public string CreatedBy { get; set; }
    }
}
