namespace tempTaskmanage.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public  string Title { get; set; }
        public  string Description { get; set; }
        public  DateTime CreateAt { get; set; }
        public DateTime? CompleteAt { get; set; }
    }
}
