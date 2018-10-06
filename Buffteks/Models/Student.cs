using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Student : Person
    {
        public int StudentID { get; set; }

        #region Methods

        public override string ToString() => $"Name: {this.FirstName} {this.LastName}\nPhone Number: {this.PhoneNumber}\n Email: {this.Email}\n";

        #endregion
    }
}