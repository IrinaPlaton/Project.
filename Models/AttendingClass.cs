namespace PROJECTCTTTT.Models
{
    public class AttendingClass
    {
        public string StudentId { get; set; } 
        public Dictionary <DateOnly,bool> Attending { get; set; }=new Dictionary<DateOnly,bool>();

    }
}
