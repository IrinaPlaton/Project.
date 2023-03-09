namespace PROJECTCTTTT.Models
{
    public class Course 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<string> ModuleList { get; set; }

        public Payment Payment { get; set; }

        public void Change(Course example)
        {
            this.Id = example.Id;
            this.Name = example.Name;
            this.Description = example.Description;
            this.ModuleList = example.ModuleList;
            this.Payment = example.Payment;
        }
    }
}
