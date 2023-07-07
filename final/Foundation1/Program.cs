using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Video 1
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
        video1.AddComment("User 3", "Can you make more videos like this?");
        video1.AddComment("User 4", "This video helped me solve my problem.");

        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            Length = 180,
            Comments = new List<Comment>()
        };

        // Add comments to Video 2
        video2.AddComment("User 1", "Nice explanation!");
        video2.AddComment("User 2", "I have a question regarding this topic.");
        video2.AddComment("User 3", "Please provide more examples.");
        video2.AddComment("User 4", "Your videos are always helpful.");

        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video
        {
            Title = "Video 3",
            Author = "Author 3",
            Length = 150,
            Comments = new List<Comment>()
        };

        // Add comments to Video 3
        video3.AddComment("User 1", "I didn't understand the last part.");
        video3.AddComment("User 2", "Could you explain it in more detail?");
        video3.AddComment("User 3", "Great job, keep it up!");

        videos.Add(video3);

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
