// Responsibility: Stores the username and text of a single comment.
// Behavior: Displays the comment with the commenter's name and text.
public class Comment
{
    private string _username = "";
    private string _commentText = "";

    // Constructor(s)
    public Comment(string username, string commentText)
    {
        _username = username.Trim();
        _commentText = commentText.Trim();
    }


    // Methods
    public void DisplayComment()
    {
        int indentSpacesCount = 10;
        string indent = new string(' ', indentSpacesCount);
        // Display comment
        Console.WriteLine($"{indent}User: {_username} \n{indent}Comment: {_commentText}\n");
    }
}
