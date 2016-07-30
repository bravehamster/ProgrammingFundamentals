using System;
using System.Linq;
namespace RoundAwayFromZero
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			double[] arr = Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ();
			double[] arrRound = new double[arr.Length];
			for (int i = 0; i < arr.Length; i++) {
				arrRound [i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);
			}

			for (int i = 0; i < arr.Length; i++) {
				Console.WriteLine ("{0} => {1}", arr[i], arrRound[i]);
			}

		}
	}
}
