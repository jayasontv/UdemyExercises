﻿using System;
using Udemy.WorkflowEngine.Interface;

namespace Udemy.WorkflowEngine
{
    public class WebServiceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Web service called");
        }
    }
}
