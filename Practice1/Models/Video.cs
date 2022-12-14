using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice1.Models
{
    public class Video
    {
        public string Title { get; }
        public int Length { get; }
        public Author Author { get; }
        public List<Comment> Comments { get; }
        
        public Video(string title, int length, Author author)
        {
            Title = title;
            Length = length;
            Author = author;
            Comments = new List<Comment>();
        }
        
        public void AddComment(Comment comment)
        {
            List<Comment> comments = Comments;
            comments.Add(comment);
        }
        
        public int CommentsCount()
        {
            return Comments.Count;
        }
    }
}