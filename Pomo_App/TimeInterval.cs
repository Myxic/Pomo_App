using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Pomo_App
{
	public class TimeInterval
	{
        private readonly int hour;
        private readonly int min;
        private readonly int sec;

	
        
		private static int ConvertInputToMillSec(string Time)
		{
			TimeInterval MyClass = new TimeInterval();
			int hour = MyClass.hour;
            int min = MyClass.min;
            int sec = MyClass.sec;
            int minToSec = 60;
            int hourToSec = minToSec * 60;
            int Idx1 = 0;
            int Idx2 = 1;
            int Idx3 = 2;

            int Length1 = 1;
            int Length2 = 2;
            int Length3 = 3;

            if (Time.Split(":").Length == Length3)
            {
                hour = int.Parse(Time.Split(":")[Idx1]);
                min = int.Parse(Time.Split(":")[Idx2]);
                sec = int.Parse(Time.Split(":")[Idx3]);
            }else if (Time.Split(":").Length == Length2)
            {
                min = int.Parse(Time.Split(":")[Idx1]);
                sec = int.Parse(Time.Split(":")[Idx2]);
            }
            else if (Time.Split(":").Length == Length1)
            {
                hour = 0;
                min = 0;
                sec = int.Parse(Time.Split(":")[Idx1]);
            }

                int TotalTime = (hour * hourToSec) + (min * minToSec) + sec;


			return TotalTime * 1000;

        }
       

        public static void DisplayTimerWork(string input)
        {
            int conversion = 1000;
            int oneSec = 1;
            int working = TimeInterval.ConvertInputToMillSec(input ?? "00:00:05") / conversion;

            Console.Clear();
            Console.WriteLine("WORK TIME");

            for (int i = 0; i < working; working--)
            {

                Thread.Sleep(conversion);
                Console.Clear();
                Console.WriteLine($"Work Time  Left:{working - oneSec} Second(s)");

            }
        }
        public static void DisplayTimerRest(string input2)
        {
            int conversion = 1000;
            int oneSec = 1;
            int resting = TimeInterval.ConvertInputToMillSec(input2) / conversion;

            Console.Clear();
            Console.WriteLine("Rest Time");

            for (int i = 0; i < resting; resting--)
            {

                Thread.Sleep(conversion);
                Console.Clear();
                Console.WriteLine($"Rest Time  Left: {resting - oneSec} Second(s)");

            }
        }

		public static void WorkTimmer(TimeSpan worktime)
		{
            Console.WriteLine($"Total Work session was {worktime.Hours} Hour(s)" +
               $"+ : + {worktime.Minutes} Minute(s)" +
               $"+ : {worktime.Seconds} Second(s)");
        }

        public static void SessionTimmer(TimeSpan SessionTimmer)
		{
            Console.WriteLine($"Total Console session was {SessionTimmer.Hours} Hour(s)" +
           $"+ : + {SessionTimmer.Minutes} Minute(s) " +
           $"+ : {SessionTimmer.Seconds} Second(s)");
        }




    }

    class TryMe
    {
        public static void checkerWork(string something)
        {
            if (string.IsNullOrEmpty(something) || string.IsNullOrEmpty(something) || something.Contains(':') == false)
            {
                Program.Run();
            }
            else
            {
                TimeInterval.DisplayTimerWork(something);
            }
        }
        public static void checkerRest(string something)
        {
            if (string.IsNullOrEmpty(something) || string.IsNullOrEmpty(something) || something.Contains(':') == false)
            {
                Program.Run();
            }
            else
            {
                TimeInterval.DisplayTimerRest(something );
            }
        }
    }
}

