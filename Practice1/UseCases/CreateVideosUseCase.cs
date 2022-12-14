using Practice1.Models;

namespace Practice1.UseCases
{
    public class CreateVideosUseCase
    {
        public Video NewVideo(string name, string authorName, int length)
        {
            var authorModel = new Author(authorName);
            var videoModel = new Video(name, length, authorModel);

            return videoModel;
        }
    }
}