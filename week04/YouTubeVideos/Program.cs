using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videosList = new List<Video>();

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

       Video video2 = new Video("Why do we dream?", "Amy Adkins", 338);

       Comment video2Comment1 = new Comment("apeking7099", "It's strange how you can't imagine a face yet when you dream your brain has perfect detail.");
       Comment video2Comment2 = new Comment("jinghay", "Has anybody ever had a dream where they know they're having a dream?");
       Comment video2Comment3 = new Comment("Jess-zf7bm", "Anyone ever cried in their dreams and when u woke up, u actually felt tears");

       video2.ListComment(video2Comment1);
       video2.ListComment(video2Comment2);
       video2.ListComment(video2Comment3);

       videosList.Add(video2);

       // Video 3
       Video video3 = new Video("The danger of scilence", "Clint Smith", 263);

       Comment video3Comment1 = new Comment("Breakability" , "Silence is the residue of fear.");
       Comment video3Comment2 = new Comment("jennamarcus4283", "He sounds like an amazing teacher and an amazing person");
       Comment video3Comment3 = new Comment("dr-maybe", "This guy would be an awesome rapper. A poet with a message, love it.");
       Comment video3Comment4 = new Comment("charonblaney" , "Thank you so much. I have been silenced for so long. Fear will no longer silence me!!");

       video3.ListComment(video3Comment1);
       video3.ListComment(video3Comment2);
       video3.ListComment(video3Comment3);
       video3.ListComment(video3Comment4);

       videosList.Add(video3);

       foreach (Video video in videosList)
       {
        video.DisplayInfo();
        Console.WriteLine();
        Console.WriteLine();
       }
    }
}