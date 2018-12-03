using System.ComponentModel.DataAnnotations;

namespace BuffteksWebApp.Models
{
    /// <summary>
    /// Abstract class for shared properties between Client and Member
    /// </summary>
    public abstract class Person
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}