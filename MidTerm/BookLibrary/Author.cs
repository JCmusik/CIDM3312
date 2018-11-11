namespace BookLibrary
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"Author name: {this.FirstName} {this.LastName}";
    }
}
