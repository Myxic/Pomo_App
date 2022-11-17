using System;
using static System.Net.Mime.MediaTypeNames;


namespace Pomo_App;
class Program
{
    static void Main(string[] args)
    {

        bool session = true;
        DateTime Start = DateTime.Now;

        while (session)
        {
            Console.Clear();
            Console.WriteLine("Enter your work time in this format (hh:mm:ss)");
            string? input = Console.ReadLine();
           
            Console.WriteLine("Enter your Rest time in this format (hh:mm:ss)");
            string? input2 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("WORK TIME");
            Thread.Sleep(TimeInterval.ConvertInputToMillSec(input ?? "00:00:05"));

            Console.Clear();
            Console.WriteLine("Rest Time");
            Thread.Sleep(TimeInterval.ConvertInputToMillSec(input2 ?? "00:00:05"));

            Console.Clear();

            DateTime End = DateTime.Now;
            TimeSpan Timmer = (End - Start);
            Console.WriteLine($"Total Console session was {Timmer.Hours} " +
                $"+ : + {Timmer.Minutes} " +
                $"+ : {Timmer.Seconds}Seconds");

            Console.WriteLine(" ");

            Console.WriteLine("Enter \"N\" TO BREAK");

            string? input3 = Console.ReadLine();

            if (input3.ToUpper() == "N")
            {
                
                session = false;
            }
            else
            {
                Console.Clear();
                continue;
            }



        }
        

        DateTime EndTime = DateTime.Now;
        TimeSpan SessionTimmer = (EndTime - Start);
        Console.WriteLine($"Total Console session was {SessionTimmer.Hours} " +
            $"+ : + {SessionTimmer.Minutes} " +
            $"+ : {SessionTimmer.Seconds}Seconds");

        

    }

}

