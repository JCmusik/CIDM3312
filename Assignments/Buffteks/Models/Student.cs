using System.Collections.Generic;

namespace Models.Models
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        public byte TableNumber { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }

        #region Methods

        public override string ToString() => $"ID: {this.StudentID} Name: {this.FirstName} {this.LastName}\nPhone Number: {this.PhoneNumber}\n Email: {this.Email}\n";

        #endregion
    }
}