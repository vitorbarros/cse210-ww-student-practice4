namespace Practice1.Models
{
    public class Comment
    {
        public string Commentary { get; }
        public Author Author { get; }
        
        public Comment(string commentary, Author author)
        {
            Commentary = commentary;
            Author = author;
        }
    }
}