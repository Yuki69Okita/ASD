using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timing
{
    public class TimingInfo
    {
        TimeSpan startingTime;
        TimeSpan duration;
        public TimingInfo()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startingTime = Process.GetCurrentProcess()
                .Threads[0]
                .UserProcessorTime;                
        }
        public void StopTime()
        {
            duration = Process.GetCurrentProcess()
                .Threads[0]
                .UserProcessorTime
                .Subtract(startingTime);
        }
        public TimeSpan Result()
        {
            return duration;
        }
    }
}
