namespace Buffteks.Models
{
    public virtual class Student : Person
    {
        public int StudentId { get; set; }
        public List<StudentTeam> StudentTeam { get; set; }
    }
}