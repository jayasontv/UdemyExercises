using System;

namespace Udemy.Stackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post()
            {
                Title = "Post1",
                Description = "Desc1",
            };

            for (int i = 0; i < 10; i++)
            {
                post.UpVote();
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    post.DownVote();
                }
                catch (InvalidOperationException)
                {
                    Output.Displaymessage("You can't downvote anymore");
                }
            }

            Output.Displaymessage(string.Format("Total votes for the post is {0}", post.GetCurrentVote()));
            Console.ReadLine();
        }
    }
}
