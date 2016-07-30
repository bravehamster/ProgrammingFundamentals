using System;
using System.Linq;

namespace CompareCharArrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] arr1 = Console.ReadLine ().Split (' ').Select (char.Parse).ToArray ();
			char[] arr2 = Console.ReadLine ().Split (' ').Select (char.Parse).ToArray ();
			bool firstIsFirst = false;
			//Console.WriteLine (string.Join(" ", arrA));

			for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++) {
				if (arr1 [i] < arr2 [i]) {
					firstIsFirst = true;
					break;
				} else if (arr1 [i] == arr2 [i]) {
					firstIsFirst = true;
				} else {
					firstIsFirst = false;
					break;
				}

			}

			if (firstIsFirst) {
				if (arr1.Length > arr2.Length) {
					Console.WriteLine (string.Join ("", arr2));
					Console.WriteLine (string.Join ("", arr1));
				} else {
					Console.WriteLine (string.Join ("", arr1));
					Console.WriteLine (string.Join ("", arr2));
				}
			} else {
				Console.WriteLine (string.Join ("", arr2));
				Console.WriteLine (string.Join ("", arr1));
			}
		}
	}
}
