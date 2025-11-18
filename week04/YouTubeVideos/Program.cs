using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("Science is awesome", "V Sauce", 240);
        Comment comment = new Comment("user134sobres", "Great video, please do more.");
        Comment comment1 = new Comment("gamergramma23", "I love science, without it we wouldn't have video games!");
        Comment comment2 = new Comment("ScienceMaster", "The video is fake, you should see my video about science.");
        video1.AddComment(comment);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        videos.Add(video1);

        Video video2 = new Video("Aaron frog", "How to find memes", 520);
        Comment commentV2 = new Comment("user134sobres", "Funny, but I didn't find the meme.");
        Comment comment1V2 = new Comment("gamergramma23", "Poor little frog, why people keep mocking him?");
        Comment comment2V2 = new Comment("ScienceMaster", "IMPOSSIBLE! Frogs do not have human features like facial expreision.");
        video2.AddComment(commentV2);
        video2.AddComment(comment1V2);
        video2.AddComment(comment2V2);
        videos.Add(video2);

        Video video3 = new Video("Can you beat Dark Souls 1 with consumables only?", "JKleeds", 480);
        Comment commentV3 = new Comment("user134sobres", "Indeed you can.");
        Comment comment1V3 = new Comment("gamergramma23", "I love his puns");
        Comment comment2V3 = new Comment("ScienceMaster", "Impressive how he managed to deafeat Artorias with throwing knives.");
        video3.AddComment(commentV3);
        video3.AddComment(comment1V3);
        video3.AddComment(comment2V3);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}