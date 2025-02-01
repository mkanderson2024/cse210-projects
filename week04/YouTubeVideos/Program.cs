using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Fundamentals", "Dude Man", 300);
        video1.AddComments("Joey Triviany", "How you doin!");
        video1.AddComments("Anthony", "You have superpowers! Thansk for the video!");
        video1.AddComments("Abby", "I'm so lost!");
        videos.Add(video1);

        Video video2 = new Video("The Difficulties of C#", "Head Thumper", 500);
        video2.AddComments("Snarky", "Head spinning!");
        video2.AddComments("Burrly", "Thanks for the tips!");
        video2.AddComments("Snapman", "That's great. Thanks!");
        videos.Add(video2);

        Video video3 = new Video("The power of C#", "Coderman", 1500);
        video3.AddComments("Jub jub", "Super helpful thanks!");
        video3.AddComments("Jen", "Thank you! Very Helpful!");
        video3.AddComments("AlextheCoder", "Thanks!");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInformation();
        }
    }
}