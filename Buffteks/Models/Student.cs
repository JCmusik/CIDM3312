using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get; set;}
        public List<StudentTeam> StudentTeam { get; set; }
    }
}