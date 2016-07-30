using System;
using System.Linq;

namespace LargestThreeNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double[] numbers = Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ();
			Console.WriteLine (string.Join (" ", numbers.OrderBy(x=>-x).Take (3)));

		}
	}
}
