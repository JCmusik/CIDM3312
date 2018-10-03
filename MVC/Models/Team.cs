namespace MVC.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public int StudentID { get; set; }  
        public Student Student { get; set; }
    }   
}