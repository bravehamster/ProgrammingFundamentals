using System;
using System.Linq;

namespace PrintReceipt
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int width = 24;

			decimal[] input = Console.ReadLine ().Split (' ').Select (decimal.Parse).ToArray ();

			Console.WriteLine ("/" + new string('-', width-2) + "\\");
			decimal total = 0;
			foreach (var num in input) {
				Console.WriteLine ("| {0, 20:f2} |", num);
				total += num;
			}

			Console.WriteLine ("|" +new string('-', width-2) +"|");
			Console.WriteLine ("| Total:{0,14:f2} |", total);
			Console.WriteLine ("\\" + new string('-', width-2) + "/");

		}
	}
}
