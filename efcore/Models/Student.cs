using System.Collections.Generic;

namespace efcore.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Project> Project { get; set; }
        
        public override string ToString() => $"{FirstName} {LastName}";
    }

}