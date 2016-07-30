using System;
using System.Linq;

namespace HourglassSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long[][] matrix = new long[6][];


			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = Console.ReadLine ().Split (' ').Select (long.Parse).ToArray ();
			}


			long currSum = long.MinValue;
			long maxSum = long.MinValue;
			for (int i = 1; i < matrix.Length-1; i++) {
				for (int j = 1; j < matrix.Length-1; j++) {
					currSum = (matrix [i - 1] [j - 1] + matrix [i - 1] [j] + matrix [i - 1] [j + 1] + matrix [i] [j] + matrix [i + 1] [j - 1] + matrix [i + 1] [j] + matrix [i + 1] [j + 1]);
					if (currSum > maxSum) {
						maxSum = currSum;
					}
				}
			}

			Console.WriteLine (maxSum);


		}
	}
}
