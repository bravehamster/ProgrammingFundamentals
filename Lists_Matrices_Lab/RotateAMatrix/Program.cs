using System;
using System.Linq;

namespace RotateAMatrix
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int rows = int.Parse (Console.ReadLine ());
			int cols = int.Parse (Console.ReadLine ());

			string[][] matrix = new string[rows][];

			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = Console.ReadLine ().Split (' ');
			}

			//int counter = 0;

			for (int i = 0; i < matrix[0].Length; i++) {
				for (int j = matrix.Length-1; j >=0; j--) {
					Console.Write (matrix[j][i] + " ");	
				}
				Console.WriteLine ();
			}

		}
	}
}
