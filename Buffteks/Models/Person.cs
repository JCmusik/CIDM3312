using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Abstract class with common properties for derived classes to inherit
    /// </summary>
    public abstract class Person
    {
    #region Properties

        [MaxLength(50)] // sets max length for property
        public string FirstName { get; set; }
        [MaxLength(50)] // sets max length for property
        public string LastName { get; set; }
        [MaxLength(70)] // sets max length for property
        public string Email { get; set; }        
        [MaxLength(20)] // sets max length for property
        public string PhoneNumber { get; set; }
        
    #endregion

    }
}