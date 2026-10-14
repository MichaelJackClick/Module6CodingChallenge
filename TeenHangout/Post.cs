namespace TeenHangout;

// Stores a post's author, content, and likes, which are set by the constructor.
public class Post
{
    public string Username { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }

    public Post(string username, string content, int likes)
    {
        Username = username;
        Content = content;
        Likes = likes;
    }
}
