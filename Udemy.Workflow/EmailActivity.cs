using System;
using Udemy.WorkflowEngine.Interface;

namespace Udemy.WorkflowEngine
{
    public class EmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email send");
        }
    }
}
