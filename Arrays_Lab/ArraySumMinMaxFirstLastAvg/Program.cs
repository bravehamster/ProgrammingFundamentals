using System;
using System.Linq;
namespace ArraySumMinMaxFirstLastAvg
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int[] arr = new int[n];
			for (int i = 0; i < arr.Length; i++) {
				arr [i] = int.Parse (Console.ReadLine ());
			}
			Console.WriteLine ("Sum = {0}", arr.Sum());
			Console.WriteLine ("Min = {0}", arr.Min());
			Console.WriteLine ("Max = {0}", arr.Max());
			Console.WriteLine ("First = {0}", arr.First());
			Console.WriteLine ("Last = {0}", arr.Last());
			Console.WriteLine ("Average = {0}", arr.Average());
		}
	}
}
