using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace logicalProblem
{
    class StopWatch
    {
        int time;
        string elapsedTime;
        TimeSpan timeSpan;
        public StopWatch(int value)
        {
            this.time = value;
        }
        public void TimeElapsed()
        {

            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(time);
            }
            timer.Stop();
            timeSpan = timer.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
            Console.WriteLine("Time elapsed: "+elapsedTime);
        }
    }
    
}
