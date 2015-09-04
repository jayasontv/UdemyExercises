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
                Description = "Decs1",
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
                    Console.WriteLine("You cant downvote anymore");
                }
            }

            Console.WriteLine(post.GetCurrentVote());
            Console.ReadLine();
        }
    }
}
