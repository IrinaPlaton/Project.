using PROJECTCTTTT.Models;

namespace PROJECTCTTTT.Controllers.Services
{
    public static class ModuleServices
    {
        public static List<Module> modules = new List<Module>() { new Module {Id = 1, Name = "Math" } ,
            new Module {Id = 2, Name = "Business and Administration" },
         new Module {Id = 3, Name = "Marketing" },};
        public static List<string> moduleNames() 
        {
            List<string> answer = new List<string>();
            foreach (var module in modules) 
            {
                answer.Add(module.Name);
            }
            return answer;
        }
    }
    
}
