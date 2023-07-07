using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        Comments.Add(newComment);
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }
}
