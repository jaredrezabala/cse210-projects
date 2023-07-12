using System.Collections.Generic;

class Video
{
    public string _Title { get; set; }
    public string _Author { get; set; }
    public int _Length { get; set; }
    public List<Comment> _Comments { get; set; }

    public int GetNumberOfComments()
    {
        return _Comments.Count;
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        _Comments.Add(newComment);
    }

    public List<Comment> GetComments()
    {
        return _Comments;
    }
}