using PROJECTCTTTT.Models;
using System.Reflection;
using System.Xml.Linq;

namespace PROJECTCTTTT.Controllers.Services
{
    public static class CourseServices
    {
        public static List<Course> courses = new List<Course>()
        {
            new Course
            {
                Id = 1, Name = "Business Accounting", ModuleList = new List<string>()
                {
                    ModuleServices.modules[0].Name, ModuleServices.modules[1].Name
                }
            },
        new Course
                {
            Id = 2, Name = "Digital Marketing ", ModuleList = new List<string>()
                      {
                ModuleServices.modules[0].Name, ModuleServices.modules[2].Name /* aici sa mai adaug module noi */ 
                       }
                 } ,

                new Course
                {
                    Id = 3, Name = "Modern Arts", ModuleList = new List<string>()
                    {
                        ModuleServices.modules[0].Name, ModuleServices.modules[2].Name
                    }
                } ,
                 new Course 
                 { 
                     Id = 4, Name = "Sports", ModuleList = new List<string>() 
                     { 
                         ModuleServices.modules[0].Name, ModuleServices.modules[2].Name
                     }
                 }
                
            
        };
        public static List<string> courseNames()
        {
            List<string> answer = new List<string>();
            foreach (var module in courses)
            {
                answer.Add(module.Name);
            }
            return answer;
        }
    }
}
