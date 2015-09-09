using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.RegisterActivity(new UploadVideoActivity());
            workflow.RegisterActivity(new WebServiceActivity());

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);

            Console.ReadLine();
        }
    }
}
