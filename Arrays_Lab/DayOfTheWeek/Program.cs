using System;

namespace DayOfTheWeek
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] arr = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
			int day = int.Parse (Console.ReadLine ());
			if (day > 0 && day < 8) {
				Console.WriteLine (arr [day - 1]);	
			} else {
				Console.WriteLine ("Invalid day!");
			}

		}
	}
}
