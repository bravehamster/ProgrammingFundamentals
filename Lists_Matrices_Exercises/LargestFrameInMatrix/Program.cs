using System;
using System.Linq;
using System.Collections.Generic;

namespace LargestFrameInMatrix
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] dims = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			int[][] matrix = new int[dims [0]][];
			for (int i = 0; i < matrix.Length; i++) {
				matrix [i] = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			}



		}

		static bool isFrame(int[][] matrix, int idx1, int idx2){
			return true;
		}
	}
}
