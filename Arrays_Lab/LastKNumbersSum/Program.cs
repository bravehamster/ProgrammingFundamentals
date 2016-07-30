using System;

namespace LastKNumbersSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int k = int.Parse (Console.ReadLine ());

			long[] arr = new long[n];
			arr [0] = 1;
			for (int i = 1; i < arr.Length ; i++) {
				long newNum = 0;
				for (int j = i-1; j >= Math.Max(0, i-k); --j) {
					newNum += arr [j];
				}
				arr [i] = newNum;
			}

			foreach (var item in arr) {
				Console.WriteLine (item);
			}
		}
	}
}
