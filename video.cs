class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        Comments.Add(comment);
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }
}