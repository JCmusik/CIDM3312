using System.Collections.Generic;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Student object
    /// </summary>
    public class Student : Person
    {
        public int StudentId { get; set; }
        public List<StudentTeam> StudentTeam { get; set; }

        public override string ToString() => $"Name: {FirstName} {LastName} \nEmail: {Email}\nPhone: {PhoneNumber}";
    }
}