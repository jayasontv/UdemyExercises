using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.WorkflowEngine.Interface;

namespace Udemy.WorkflowEngine
{
    public class StatusUpdateActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status updated");
        }
    }
}
