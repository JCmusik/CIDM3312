using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Abstract class with common properties for derived classes to inherit
    /// </summary>
    public abstract class Person
    {
    #region Properties

      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }        
        public string PhoneNumber { get; set; }
        
    #endregion

    }
}