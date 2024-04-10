using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Sample Video 1", "John Doe", 245);
        Video video2 = new Video("Sample Video 2", "Jane Doe", 120);
        Video video3 = new Video("Sample Video 3", "Mike Johnson", 360);

        // Add comments to videos
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Bob", "Thanks for sharing!");
        video2.AddComment("Charlie", "Interesting topic!");
        video3.AddComment("David", "I learned something new!");
        video3.AddComment("Eva", "Thanks for the detailed explanation!");

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}