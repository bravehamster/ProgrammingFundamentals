using System;
using System.Globalization;

namespace DayOfWeek
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] date = Console.ReadLine ().Split ('-');
			DateTime d = new DateTime (int.Parse (date[2]), int.Parse (date[1]), int.Parse (date[0]));
			Console.WriteLine (d.DayOfWeek);
		}
	}
}
