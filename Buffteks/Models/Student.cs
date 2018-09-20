using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public List<StudentTeam> StudentTeam { get; set; }
    }
}