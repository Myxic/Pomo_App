using System;
using static System.Net.Mime.MediaTypeNames;


namespace Pomo_App;
class Program
{
    static void Main(string[] args)
    {


        Program.Run();

    }
    public static void Run()
    {
        bool session = true;
        DateTime Start = DateTime.Now;

        while (session)
        {
            string WorkTime = TryMe.checkerWork();
            string RestTime = TryMe.checkerRest();

           

            DateTime StartTime = DateTime.Now;

            TimeInterval.DisplayTimerWork(WorkTime);
            TimeInterval.DisplayTimerRest(RestTime);
           


            Console.Clear();

            DateTime End = DateTime.Now;
            TimeSpan Timmer = (End - StartTime);


            TimeInterval.WorkTimmer(Timmer);


            Console.WriteLine(" ");


            Console.WriteLine("Enter \"N\" TO BREAK OR Enter any key to CONTINUE ");


            string? input3 = Console.ReadLine();
            string reply = input3 ?? "h";

            if (reply.ToUpper() == "N")
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

        TimeInterval.SessionTimmer(SessionTimmer);

    }

}

