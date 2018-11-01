namespace BookLibrary
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"Author name: {this.Name}";
    }
}
