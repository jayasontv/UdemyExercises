
using System.Collections.Generic;
namespace Udemy.WorkflowEngine.Interface
{
    public interface IWorkflow
    {
        void RegisterActivity(IActivity activity);

        IEnumerable<IActivity> GetActivities();
    }
}
