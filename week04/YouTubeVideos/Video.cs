// Responsibility: 
// Behavior: 
public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0; // Time in seconds
    private List<Comment> _commentsList = new List<Comment>();
    
    // Constructor(s)
    public Video(string title,string author,int length)
    {
        // Create Video object
        // TODO
    }
    
    // Methods
    public void AddComment(Comment comment)
    {
        // Add comment to list on video
        _commentsList.Append(comment);
    }
    public string DisplayDetails()
    {
        // Return string for display details
        // TODO
        return "";
    }
    public int GetCommentCount()
    {
        // Get the count of comments on video
        int commentCount = _commentsList.Count;
        return commentCount;
    }

}
