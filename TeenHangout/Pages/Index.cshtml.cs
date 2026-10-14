using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

public class IndexModel : PageModel
{
    // Store the five members and their details.
    public User[] Users { get; } =
    [
        new("MusicLover", 15, "Purple"),
        new("GamerGirl", 16, "Red"),
        new("BookwormBen", 15, "Yellow"),
        new("SportsFan", 17, "Blue"),
        new("ArtistAmy", 14, "Green")
    ];

    // Store five posts. Each username matches a member in Users.
    public Post[] Posts { get; } =
    [
        new("GamerGirl", "Anyone want to play online later?", 30),
        new("BookwormBen", "Reading the best book ever!", 15),
        new("MusicLover", "Concert next week! So excited!", 22),
        new("SportsFan", "Who wants to play basketball?", 20),
        new("ArtistAmy", "Just finished a new drawing!", 8)
    ];
}
