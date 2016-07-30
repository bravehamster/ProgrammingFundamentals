using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> inputList = Console.ReadLine ().Split (' ').Select (int.Parse).ToList ();

			inputList.Sort ((q,w) => -1*q.CompareTo (w));

			int curr = 0;
			while (curr < inputList.Count) {
				if (Math.Sqrt (inputList[curr])%1.0 != 0) {
					inputList.RemoveAt (curr);
					curr--;
				}	
				curr++;
			}

			Console.WriteLine (string.Join (" ", inputList));
		
		}
	}
}
