using System;

namespace EFIA
{
    public class Book
    {
        //This holds the Primary Key of the Books row in the database
        public int BookId { get; set; }         //PRMARY KEY

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        //This holds the Foreign Key which references the Author row holding the name of the author        
        public int AuthorId { get; set; }       //FOREIGN KEY


        //EF Core will create a link to the Author class using the AuthroId foreign key
        //so, if we find an author, we can store the Author record here
        public Author Author { get; set; }      //FK REFERENCE
    }
}