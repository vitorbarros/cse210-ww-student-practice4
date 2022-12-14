using System;
using System.Collections.Generic;
using Practice1.Models;
using Practice1.UseCases;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            var comment = new CreateCommentUseCase();
            var comment1 = comment.NewComment("Fist comment", "Matt");
            var comment2 = comment.NewComment("Second comment", "John");
            var comment3 = comment.NewComment("Third comment", "James");

            var video = new CreateVideosUseCase();
            var video1 = video.NewVideo("Video 1", "Peter", 120);
            var video2 = video.NewVideo("Video 2", "Peter", 121);
            var video3 = video.NewVideo("Video 3", "Peter", 122);
            
            
            video1.AddComment(comment1);
            video1.AddComment(comment2);
            video1.AddComment(comment3);
            
            video2.AddComment(comment1);
            video2.AddComment(comment2);
            video2.AddComment(comment3);
            
            video3.AddComment(comment1);
            video3.AddComment(comment2);
            video3.AddComment(comment3);

            List<Video> videos = new List<Video>();
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            foreach (Video v in videos)
            {
                Console.WriteLine("Video -> Title: " + v.Title + " Author: " + v.Author.Name + " Duration: " + v.Length);

                foreach (Comment c in v.Comments)
                {
                    Console.WriteLine("      Comments -> Title: " + c.Commentary + " Author: " + v.Author.Name);
                }
            }
        }
    }
}
