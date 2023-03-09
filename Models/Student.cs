namespace PROJECTCTTTT.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public DateOnly Birthday { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public string Grade { get; set; }
        public string Phone { get; set; }

        public string Course {get; set; }

        public void clone ( Student student) {
        
        this.Id= student.Id;
            this.FirstName= student.FirstName;
            this.LastName= student.LastName;
            this.Email= student.Email;
            this.Birthday= student.Birthday;
            this.Faculty= student.Faculty;
            this.Specialization= student.Specialization;
            this.Grade= student.Grade;
            this.Phone= student.Phone;
            this.Course= student.Course;
        }
    }

   
}
