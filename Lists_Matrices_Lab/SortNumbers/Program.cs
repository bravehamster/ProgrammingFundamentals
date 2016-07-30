using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<decimal> inputList = Console.ReadLine ().Split (' ').Select (decimal.Parse).ToList ();

			inputList.Sort ();
			Console.WriteLine (string.Join(" <= ", inputList));
		}
	}
}
