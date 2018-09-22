using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Abstract class with common properties for derived classes to inherit
    /// </summary>
    public abstract class Person
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
    }
}