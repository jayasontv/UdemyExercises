using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Udemy.WorkflowEngine
{
    public class Workflow
    {
        public IList<IActivity> Activities { get; private set; }

        public Workflow()
        {
            Activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}
