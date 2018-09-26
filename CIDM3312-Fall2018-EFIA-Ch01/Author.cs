using System;

namespace EFIA
{
    public class Author
    {
        //EF assumes that an attribute with "ID" in the name is a primary key
        public int AuthorId { get; set; }    //PRIMARY KEY
        public string Name { get; set; }
        public string WebUrl { get; set; }
    }
}