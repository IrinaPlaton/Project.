using PROJECTCTTTT.Models;

namespace PROJECTCTTTT.Controllers.Services
{
    public static class StudentServices
    {// holds students
        public static List<Student> Students { get; set; }=new List<Student>()
        {

            new Student()
            { 
            Id= 1, FirstName   = "Irina" , LastName = "Platon" , Course = CourseServices.courses[0].Name
            },
             new Student()
            {
            Id= 2, FirstName   = "Eugeniu" , LastName = "Bajuerea" , Course = CourseServices.courses[1].Name
            },
              new Student()
            {
            Id= 3, FirstName   = "Angela" , LastName = "Ungureanu" , Course = CourseServices.courses[0].Name
            },
               new Student()
            {
            Id= 4, FirstName   = "Ion" , LastName = "Palade" , Course = CourseServices.courses[1].Name
            },
                 new Student()
            {
            Id= 5, FirstName   = "Iulya" , LastName = "Anton" , Course = CourseServices.courses[0].Name
            },
        };

    }

}
