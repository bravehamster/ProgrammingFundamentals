using System;

namespace ReverseArrayOfIntegers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int arrLen = int.Parse (Console.ReadLine ());
			int[] arr = new int[arrLen];
			for (int i = arr.Length-1; i >= 0; i--) {
				arr[i] = int.Parse(Console.ReadLine());
			}
			foreach (var number in arr) {
				Console.Write (number + " ");
			}
		}
	}
}
