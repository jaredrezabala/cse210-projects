using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Video objects and set their attributes
        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            Length = 120,
            Comments = new List<Comment>()
        };

        // Add comments to Video 1
        video1.AddComment("User 1", "Great video!");
        video1.AddComment("User 2", "I learned a lot.");

        videos.Add(video1);

        // Repeat the process for other videos
        // ...

        // Iterate through the list of videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            List<Comment> comments = video.GetComments();
            Console.WriteLine("Comments:");

            foreach (Comment comment in comments)
            {
                Console.WriteLine("- Comment by " + comment.CommenterName + ": " + comment.CommentText);
            }

            Console.WriteLine();
        }
    }
}
