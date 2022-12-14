using Practice1.Models;

namespace Practice1.UseCases
{
    public class CreateCommentUseCase
    {
        public Comment NewComment(string commentary, string authorName)
        {
            var author = new Author(authorName);
            var comment = new Comment(commentary, author);

            return comment;
        }

        public Video AddComment(Video video, Comment comment)
        {
            video.AddComment(comment);
            return video;
        }
    }
}