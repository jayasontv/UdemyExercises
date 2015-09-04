using System;

namespace Udemy.Stackoverflow
{
    public class Post
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; private set; }

        public int voteCount { get; private set; }

        public Post()
        {
            this.CreatedDate = DateTime.Now;
        }

        public void UpVote()
        {
            voteCount++;
        }

        public void DownVote()
        {
            if (voteCount == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                voteCount--;
            }

        }

        public int GetCurrentVote()
        {
            return voteCount;
        }

    }
}
