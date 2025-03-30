using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("Introduction to Sound Design for Stage Productions", "Samantha Green", 420);
        Video vid2 = new Video("Microphone Placement and Setup in Theaters", "David Johnson", 360);
        Video vid3 = new Video("Mixing Basics for Live Performances", "Rachel Adams", 600);

        vid1.AddComment(new Comment("Mike", "Great overview! The section on digital consoles was very helpful."));
        vid1.AddComment(new Comment("Sarah", "I’m just starting out, so this intro was perfect."));
        vid1.AddComment(new Comment("Tom", "Would love more details on signal flow and wiring."));

        vid2.AddComment(new Comment("Liz", "Exactly what I needed for my small stage production."));
        vid2.AddComment(new Comment("John", "The diagrams of mic placement were super clear."));
        vid2.AddComment(new Comment("Angela", "Any tips on dealing with feedback in live theater?"));

        vid3.AddComment(new Comment("Jacob", "Never realized how important EQ was until now."));
        vid3.AddComment(new Comment("Kevin", "The live demos with different styles of music were awesome."));
        vid3.AddComment(new Comment("Claire", "Helped me fix my mix issues on opening night. Thanks!"));

        List<Video> videos = new List<Video> { vid1, vid2, vid3 };

        foreach (Video vid in videos)
        {
            vid.DisplayVideoDetails();
            vid.DisplayAllComments();

            Console.WriteLine();
        }

    }
}