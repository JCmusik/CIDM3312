using System.Collections.Generic;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Student object
    /// </summary>
    public class Student : Person
    {
    #region Properties

        // primary key
        public int StudentId { get; set; }

        /// <summary>
        /// Used for Many to Many Relationships between Student and Team classes
        /// <see cref="https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many">
        /// </summary>
        public List<StudentTeam> StudentTeam { get; set; }

        #endregion

    #region Methods
        // String representaion of class
        public override string ToString() => $"Name: {FirstName} {LastName} \nEmail: {Email}\nPhone: {PhoneNumber}";
    #endregion
    }
}