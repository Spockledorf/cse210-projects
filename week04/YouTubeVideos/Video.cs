// Responsibility: Stores the title, author, length, and comments of a single video.
// Behavior: Accepts new comments, counts comments, and displays all video details and comments.

public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0; // Time in seconds
    private List<Comment> _commentsList = new List<Comment>();

    // Constructor(s)
    public Video(string title, string author, int length)
    {
        // Create Video object
        _title = title.Trim();
        _author = author.Trim();
        _length = length;
    }

    // Methods
    public void AddComment(Comment comment)
    {
        // Add comment to list on video
        _commentsList.Add(comment);
    }
    public void DisplayDetails()
    {
        // Return string for display details
        // TODO
        string videoTitle = _title;
        string videoAuthor = _author;
        int videoDuration = _length;
        int videoCommentCount = GetCommentCount();

        // Potential improvement: Make the duration show as 00h:00m:00s
        // int videoLengthSeconds;
        // int videoLengthMinutes;
        // int videoLengthHours;

        string videoStatText = $"Video: '{videoTitle}' | Uploaded by: {videoAuthor} | Duration: {videoDuration} seconds \nComments: {videoCommentCount}";
        Console.WriteLine(" ------------------------------------------------ ");
        Console.WriteLine(videoStatText.ToString());

        // then list out all of the comments for that video. 
        Console.WriteLine(" ------------------------------------------------ ");
        foreach (Comment comment in _commentsList)
        {
            comment.DisplayComment();
        }
    }
    public int GetCommentCount()
    {
        // Get the count of comments on video
        int commentCount = _commentsList.Count;
        return commentCount;
    }
}
