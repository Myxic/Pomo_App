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
            Console.Clear();
            Console.WriteLine("Enter your work time in this format (hh:mm:ss)");
            string? input = Console.ReadLine();

            Console.WriteLine("Enter your Rest time in this format (hh:mm:ss)");
            string? input2 = Console.ReadLine();


            DateTime StartTime = DateTime.Now;


            TryMe.checkerWork(input ?? "");

            


            TryMe.checkerRest(input2 ?? "");
            

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

