using System;

namespace Udemy.Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }

        public DateTime EndTime { get; private set; }

        public bool StopwatchStarted { get; private set; }

        public void Start()
        {
            if (StopwatchStarted)
            {
                throw new InvalidOperationException();
            }
            else
            {
                StartTime = DateTime.UtcNow;
                StopwatchStarted = true;
            }
        }

        public void Stop()
        {
            if (StopwatchStarted)
            {
                EndTime = DateTime.UtcNow;
                StopwatchStarted = false;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }
    }
}
