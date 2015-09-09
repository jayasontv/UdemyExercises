using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.Activities)
            {
                activity.Execute();
            }
        }
    }
}
