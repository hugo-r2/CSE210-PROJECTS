using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("You've NEVER Seen a 3D Printer DO THIS!", "3D Printing Nerd", 394);
        video1.AddComment(new Comment("thomasdassinger5091", "That's straight forward awesome. Hope this Voron Mod takes us one step forward in the world of non-planar slicing, although its not intended for it."));
        video1.AddComment(new Comment("davel9130", "I love how many times Joel says, Wait.  What?in this video."));
        video1.AddComment(new Comment("ThriamTV", "From pixels to perfection—3D printing brings ideas to life!"));

        Video video2 = new Video("Batman Arkham Shadow - Before You Buy", "gameranx", 772);
        video2.AddComment(new Comment("jimcurtis9052", "I still think Bioshock would be a perfect candidate for VR."));
        video2.AddComment(new Comment("faaffa", "It's weird to be playing as myself (I'm Batman)"));

        Video video3 = new Video("Street Fighter : La Saga en 1 Video", "El Fedelobo", 2348);
        video3.AddComment(new Comment("ozkareduardo779", "Que trabajo bro, neta mas de 30 años resumidos en media hora, una verdadera chulada fede"));
        video3.AddComment(new Comment("BlackRider76", "Capcom debería mandar a hacer un anime completo de Street Fighter"));
        video3.AddComment(new Comment("Jack", "I learned a lot from this."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine();
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}