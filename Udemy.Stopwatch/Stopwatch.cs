using System;

namespace Udemy.Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }

        public DateTime EndTime { get; private set; }

        private bool _isStarted;

        public void Start()
        {
            if (_isStarted)
            {
                throw new InvalidOperationException();
            }
            else
            {
                StartTime = DateTime.UtcNow;
                _isStarted = true;
            }
        }

        public void Stop()
        {
            if (_isStarted)
            {
                EndTime = DateTime.UtcNow;
                _isStarted = false;
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
