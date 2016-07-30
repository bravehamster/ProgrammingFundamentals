using System;
using System.Linq;

namespace Tour
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = int.Parse (Console.ReadLine ());
			int[][] cities = new int[num][];

			for (int i = 0; i < cities.Length; i++) {
				cities [i] = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			}

			int[] visit = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			int sumDistances = 0;
			int prev = 0;

			for (int i = 0; i < visit.Length; i++) {
				sumDistances += cities [prev][visit [i]];
				prev = visit [i];
			}

			Console.WriteLine (sumDistances);

		}
	}
}
