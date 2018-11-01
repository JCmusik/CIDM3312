namespace BookLibrary
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"Author Name: {this.Name}";

    }
}