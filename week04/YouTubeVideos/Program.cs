using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Video 1";
        video1._author = "Author 1";
        video1._length = 100;
        video1._comments.Add(new Comment("Comment 1", "Author 1"));
        video1._comments.Add(new Comment("Comment 2", "Author 2"));
        video1._comments.Add(new Comment("Comment 3", "Author 3"));
        Video video2 = new Video();
        video2._title = "Video 2";
        video2._author = "Author 2";
        video2._length = 200;
        video2._comments.Add(new Comment("Comment 4", "Author 4"));
        video2._comments.Add(new Comment("Comment 5", "Author 5"));
        video2._comments.Add(new Comment("Comment 6", "Author 6"));
        Video video3 = new Video();
        video3._title = "Video 3";
        video3._author = "Author 3";
        video3._length = 300;
        video3._comments.Add(new Comment("Comment 7", "Author 7"));
        video3._comments.Add(new Comment("Comment 8", "Author 8"));
        video3._comments.Add(new Comment("Comment 9", "Author 9"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
    
}