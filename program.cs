class Program
{
    static void Main()
    {
        // Creating 3-4 videos and adding comments
        Video video1 = new Video("Introduction to C#", "C# Guru", 300);
        video1.AddComment("User1", "Great tutorial!");
        video1.AddComment("User2", "I learned a lot!");

        Video video2 = new Video("ASP.NET Core Basics", "ASP.NET Expert", 450);
        video2.AddComment("User3", "This is helpful!");
        video2.AddComment("User4", "Could you explain middleware more?");

        Video video3 = new Video("Unity Game Development", "GameDev Pro", 600);
        video3.AddComment("User5", "Awesome content!");
        video3.AddComment("User6", "I'm starting my Unity journey!");

        Video video4 = new Video("Database Design Principles", "DB Pro", 400);
        video4.AddComment("User7", "Very informative.");
        video4.AddComment("User8", "Could you cover normalization more?");

        // Putting videos on the list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // It goes through the list, displaying information
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.LengthSeconds);
            Console.WriteLine("Number of Comments: " + video.GetNumComments());

            // Displaying all comments for the video
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine("\n");
        }
    }
}