using System;

namespace BookLibrary
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public int Pages { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public override string ToString() => $"Title: {this.Title}\nPublisher: {this.Publisher}\nPublish Date: {this.PublishDate}\nPages: {this.Pages}\n{this.Author}";
    }
}
