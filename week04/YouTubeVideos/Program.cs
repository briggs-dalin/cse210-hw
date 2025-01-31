using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videosList = new List<Video>;

       //Video 1
       Video video1 = new Video("The History of chocolate", "Deanna Pucciarelli", 281);

       Comment video1Comment1 = new Comment("eyuin5716", "The mesoamericans also gave us corn and vanilla.");
       Comment video1Comment2 = new Comment("iwritetotastelifetwice", "can we appreciate how elegant the animation is");
       Comment video1Comment3 = new Comment("MicahRion", "Cortez visited. That was pretty generous summary of colonization.");

       video1.ListComment(video1Comment1);
       video1.ListComment(video1Comment2);
       video1.ListComment(video1Comment3);

       videosList.Add(video1);

       // Video 2

       Video video2 = new Video("");

       Comment video2Comment1 = new Comment();
       Comment video2Comment2 = new Comment();
       Comment video2Comment3 = new Comment();

       video1.ListComment(video2Comment1);
       video1.ListComment(video2Comment2);
       video1.ListComment(video2Comment3);

       videosList.Add(video2);

       // Video 3
       Video video3 = new Video("");

       Comment video3Comment1 = new Comment();
       Comment video3Comment2 = new Comment();
       Comment video3Comment3 = new Comment();

       video1.ListComment(video3Comment1);
       video1.ListComment(video3Comment2);
       video1.ListComment(video3Comment3);

       videosList.Add(video3);
    }
}