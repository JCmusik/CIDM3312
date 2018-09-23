namespace efcore.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public override string ToString() => $"Project: {Name}";
    }
}