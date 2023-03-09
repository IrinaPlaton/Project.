namespace PROJECTCTTTT.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lecturer { get; set; }
        public int CreditValue { get; set; }

        public void clone(Module module) { 
         this.Id= module.Id;
            this.Name= module.Name;
            this.Description= module.Description;
            
            this.Lecturer= module.Lecturer;
            this.CreditValue= module.CreditValue;
        
        
        
        }

    }
}
