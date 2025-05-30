using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main()
        {
            // Create videos
            var videos = new List<Video>
            {
                new Video("The Art of Makeup", "Chocogoddess", 420),
                new Video("Nail Art Tutorial", "Chocogoddess", 300),
                new Video("Glam Goddess BTS", "Chocogoddess", 180)
            };

            // Add comments to each video
            videos[0].AddComment(new Comment("Alice", "Love this look!"));
            videos[0].AddComment(new Comment("Bob", "Great tips, thanks!"));
            videos[0].AddComment(new Comment("Carla", "Where did you get that palette?"));

            videos[1].AddComment(new Comment("Dave", "My nails never look this good."));
            videos[1].AddComment(new Comment("Eva", "Saving this for later!"));
            videos[1].AddComment(new Comment("Frank", "Can you do a French set next?"));

            videos[2].AddComment(new Comment("George", "So inspiring!"));
            videos[2].AddComment(new Comment("Hannah", "That lighting is perfect."));
            videos[2].AddComment(new Comment("Ian", "Love the behind-the-scenes!"));
            
             // Display all videos and their comments
            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Comments ({video.GetCommentCount()}):");
                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"  - {comment}");
                }
                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
