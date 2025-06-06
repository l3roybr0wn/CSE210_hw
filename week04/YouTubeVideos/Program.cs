using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public int CommentCount => Comments.Count;
}

public class Comment
{
    public string Commenter { get; set; }
    public string Text { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project."); // This line is now correctly placed
        List<Video> videos = new List<Video>()
        {
            new Video
            {
                Title = "Amazing Nature Scenery",
                Author = "John Doe",
                Length = 300,
                Comments = new List<Comment> {
                    new Comment { Commenter = "Jane", Text = "Great video!"
                    },
                    new Comment { Commenter = "Peter", Text = "Stunning views!"
                    },
                    new Comment { Commenter = "Mary", Text = "I loved it!"
                    }
                }
            },
            new Video
            {
                Title = "Funny Cat Videos",
                Author = "Jane Smith",
                Length = 120,
                Comments = new List<Comment> {
                    new Comment { Commenter = "Bob", Text = "Hilarious!"
                    },
                    new Comment { Commenter = "Alice", Text = "So cute!"
                    }
                }
            }
        };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}\nAuthor: {video.Author}\nLength: {video.Length} seconds\nNumber of Comments: {video.CommentCount}");
            Console.WriteLine($"--- Comments ---");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Commenter: {comment.Commenter}, Text: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
