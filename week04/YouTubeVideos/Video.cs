using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int LengthInSeconds { get; }

        private readonly List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public IEnumerable<Comment> GetComments()
         {
            return _comments;
        }
    }
}
