using System;
using System.Linq;

namespace BombNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] inputNumbers = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			int[] bomb 		   = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			for (int i = 0; i < inputNumbers.Length; i++) {
				if (inputNumbers[i] == bomb[0]) {
					bombNumbers (inputNumbers, i, bomb[0], bomb[1]);
				}
			}

			Console.WriteLine (sumMatrix (inputNumbers));


		}

		static void bombNumbers(int[] numbers, int bombIdx, int bombNum, int bombLen){
			for (int j = Math.Max(bombIdx-bombLen, 0); j < Math.Min(bombIdx+bombLen+1, numbers.Length); j++) {
				numbers [j] = 0;
			}
		}

		static int sumMatrix(int[] matrix){
			int total = 0;

			for (int i = 0; i < matrix.Length; i++) {
				total += matrix [i];
			}
			return total;
		}


	}
}
