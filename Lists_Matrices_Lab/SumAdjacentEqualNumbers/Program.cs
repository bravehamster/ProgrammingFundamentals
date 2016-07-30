using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<decimal> inputList = Console.ReadLine ().Split (' ').Select (decimal.Parse).ToList();
			int curr = 0;
			while (curr < inputList.Count-1) {
				if (inputList[Math.Max(curr, 0)]==inputList[curr+1] && curr>=0) {
					inputList.RemoveAt (curr);
					inputList [curr] *= 2;
					curr-=2;
				}
				curr++;
			}

			Console.WriteLine (string.Join(" ", inputList));
		
		}
	}
}
