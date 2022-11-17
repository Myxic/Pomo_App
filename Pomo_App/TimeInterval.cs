using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Pomo_App
{
	public class TimeInterval
	{
        public int hour;
        public int min;
        public int sec;

	

		public static int ConvertInputToMillSec(string Time)
		{
			var MyClass = new TimeInterval();
			int hour = MyClass.hour;
            int min = MyClass.min;
            int sec = MyClass.sec;


            hour = int.Parse(Time.Split(":")[0]);
			min = int.Parse(Time.Split(":")[1]);
			sec = int.Parse(Time.Split(":")[2]);
		
			int TotalTime = (hour * 60 * 60) + (min * 60) + sec;


			return TotalTime * 1000;

        }
	




    }
}

