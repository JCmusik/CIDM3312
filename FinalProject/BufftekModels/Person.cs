namespace BufftekModels
{
    /// <summary>
    /// Abstract class for shared properties between Client and Member
    /// </summary>
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}