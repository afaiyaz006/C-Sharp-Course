using System;

namespace AdvancedExercises
{
    class StopWatch
    {
        private DateTime? startTime;
        private DateTime? stopTime;
        private bool isRunning;

        public void Start()
        {
            if (isRunning)
            {
                throw new InvalidOperationException("Time is already running.");
            }
            startTime = DateTime.Now;
            isRunning = true;
        }

        public void Stop()
        {
            stopTime = DateTime.Now;
            isRunning = false;
        }

        public void Display()
        {
            if (startTime == null)
            {
                Console.WriteLine("Stopwatch has not been started.");
                return;
            }

            TimeSpan elapsed;
            if (isRunning)
            {
                elapsed = DateTime.Now - startTime.Value;
            }
            else
            {
                elapsed = stopTime.Value - startTime.Value;
            }

            Console.WriteLine("Elapsed Time: " + elapsed);
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            StopWatch sw = new StopWatch();

            sw.Start();
            Console.WriteLine("Stopwatch started.");
            sw.Stop();
            Console.WriteLine("Stopwatch stopped.");

            sw.Display();
        }
    }
}
