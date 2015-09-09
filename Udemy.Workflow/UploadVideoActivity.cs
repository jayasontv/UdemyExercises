using System;
using Udemy.WorkflowEngine.Interface;

namespace Udemy.WorkflowEngine
{
    public class UploadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded");
        }
    }
}
