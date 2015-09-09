using Udemy.WorkflowEngine.Interface;

namespace Udemy.WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
