namespace Buffteks.Models
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        public int AdvisorID { get; set; }
        public Advisor Advisor { get; set; }
    }
}