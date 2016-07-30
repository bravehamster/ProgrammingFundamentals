using System;
using System.Linq;

namespace SumArrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr1 = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			int[] arr2 = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

			int[] sum = new int[Math.Max(arr1.Length, arr2.Length)];
		
			for (int i = 0; i < sum.Length; i++) {
				sum [i] = arr1 [i % (arr1.Length)] + arr2 [i % (arr2.Length)];
			}

			foreach (var item in sum) {
				Console.Write (item + " ");
			}
		}
	}
}
