using System;
using System.Linq;

namespace DiagonalDifference
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			double[][] matrix = new double[n][];

			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ();
			}

			double diagonalA = 0;
			double diagonalB = 0;

			for (int i = 0; i < matrix.Length; i++) {
				for (int j = 0; j < matrix.Length; j++) {
					if (i==j) {
						diagonalA += matrix [i] [j];
					}
					if (j==n-i-1) {
						diagonalB += matrix [i] [j];
					}
				}
			}

			Console.WriteLine (Math.Abs (diagonalA-diagonalB));


		}
	}
}
