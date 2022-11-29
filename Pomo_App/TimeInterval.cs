using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Pomo_App
{
    internal class TimeInterval
    {
        private static  int hour;
        private static int min;
        private static int sec;



        private static int ConvertInputToMillSec(string Time)
        {
            
            int minToSec = 60;
            int hourToSec = minToSec * 60;
            int Idx1 = 0;
            int Idx2 = 1;
            int Idx3 = 2;
            int conversion = 1000;

            hour = int.Parse(Time.Split(":")[Idx1]);
            min = int.Parse(Time.Split(":")[Idx2]);
            sec = int.Parse(Time.Split(":")[Idx3]);


            int TotalTime = (hour * hourToSec) + (min * minToSec) + sec;


            return TotalTime * conversion;

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
        private static readonly string patternText = @"^([0-9]{2}):([0-6]{1})([0-9]{1}):([0-6]{1})([0-9]{1})$";
        private static readonly Regex reg = new Regex(patternText);
        private static string? _valid;

        public static string checkerWork()
        {

            Console.WriteLine("Enter your work time in this format (hh:mm:ss)");
            string? input = Console.ReadLine();
            if (!reg.IsMatch(input))
            {
                Console.Clear();
                Console.WriteLine("Wrong Format: Please Enter your work time in this format (hh:mm:ss)");
                checkerWork();
            }
            if (reg.IsMatch(input))
            {
                _valid = input;
            }

            return _valid;

        }
        public static string checkerRest()
        {
            Console.WriteLine("Enter your Rest time in this format (hh:mm:ss)");
            string? input2 = Console.ReadLine();

            //if (string.IsNullOrEmpty(something) || string.IsNullOrEmpty(something) || something.Contains(':') == false)
            if (!reg.IsMatch(input2))
            {
                Console.Clear();
                Console.WriteLine("Wrong Format: Please Enter your rest time in this format (hh:mm:ss)");
                checkerRest();
            }
            if (reg.IsMatch(input2))
            {
                _valid = input2;
            }

            return _valid;
            //TimeInterval.DisplayTimerRest(input2);

        }
    }
}

