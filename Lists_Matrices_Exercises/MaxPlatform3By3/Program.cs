using System;
using System.Linq;

namespace MaxPlatform3By3
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			long[] input = Console.ReadLine ().Split (' ').Select (long.Parse).ToArray ();
			long[][] matrix = new long[input [0]][];

			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = Console.ReadLine ().Split (' ').Select (long.Parse).ToArray ();
			}
				
			long [][] resultMat = new long[3][];
			for (int i = 0; i < resultMat.Length; i++) {
				resultMat[i] = new long[3];
			}
			long curRowSum = 0;
			long nextRowSum = 0;
			long thirdRowSum = 0;
			long resultMatSum = long.MinValue;

			for (int i = 0; i < matrix.Length-2; i++) {
				for (int j = 0; j < matrix[i].Length-2; j++) {
					curRowSum = matrix [i] [j] + matrix [i] [j + 1] + matrix [i] [j + 2];
					nextRowSum = matrix [i+1] [j] + matrix [i+1] [j + 1] + matrix [i+1] [j + 2];
					thirdRowSum = matrix [i+2] [j] + matrix [i+2] [j + 1] + matrix [i+2] [j + 2];

					if (curRowSum+nextRowSum+thirdRowSum > resultMatSum) {
						resultMatSum = curRowSum + nextRowSum + thirdRowSum;

						for (int k = 0; k < 3; k++) {
							for (int l = 0; l < 3; l++) {
								resultMat [k] [l] = matrix [i + k] [j + l];
							}
						}
					}

				}
			}
				
			Console.WriteLine (resultMatSum);


			for (int i = 0; i < resultMat.Length; i++) {
				Console.WriteLine (string.Join (" ", resultMat[i]));
			}


		}

	}
}
