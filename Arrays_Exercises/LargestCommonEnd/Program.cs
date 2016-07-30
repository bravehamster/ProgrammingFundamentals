using System;

namespace LargestCommonEnd
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] arr1 = Console.ReadLine ().Split (' ');
			string[] arr2 = Console.ReadLine ().Split (' ');
			int counterFromLeft = countCommonEnds(arr1, arr2);

			string[] arr1Rev = reverseArray (arr1);
			string[] arr2Rev = reverseArray (arr2);

			int counterFromRight = countCommonEnds (arr1Rev, arr2Rev);

			Console.WriteLine (Math.Max(counterFromLeft, counterFromRight));

		}

		public static int countCommonEnds(string[] arr1, string[] arr2){
			int counter = 0;
			for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++) {
				if (arr1 [i].Contains (arr2 [i])) {
					counter++;
				} else {
					break;
				}
			}
			return counter;
		}

		public static string[] reverseArray(string[] arr){
			for (int i = 0; i < arr.Length/2; i++) {
				string first = arr [i];
				string last = arr [arr.Length - i - 1];

				arr [i] = last;
				arr [arr.Length - i - 1] = first;
			}
			return arr;
		}

			
	}
}
