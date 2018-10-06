namespace Buffteks.Models
{
    public class Advisor : Person
    {
        public int AdvisorID { get; set; }
        public string Title { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}