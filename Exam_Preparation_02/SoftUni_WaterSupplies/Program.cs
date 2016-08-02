using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_WaterSupplies
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long totalWater = long.Parse (Console.ReadLine ());
			decimal[] bottles = Console.ReadLine ().Split (' ').Select (decimal.Parse).ToArray ();
			long bottleCap = long.Parse (Console.ReadLine ());
		
			//If the total water is an even number, you will start filling the bottles from the beginning of the array
			//In case you run out of water, you need to print the indexes of the empty bottles in the same order in which you are traversing the array.

			List<int> unfilled = new List<int> ();

			decimal allWater = (decimal)totalWater;
			decimal bottleCapacity = (decimal)bottleCap;

			if (totalWater%2==0) 
			{
				for (int i = 0; i < bottles.Length; i++) {
					if (allWater< (bottleCapacity-bottles[i])) {
						unfilled.Add (i);
					}
					allWater -= (bottleCapacity-bottles[i]);
				}
			}
			else
			{
				for (int i = bottles.Length-1; i >= 0; i--) {
					if (allWater < (bottleCapacity-bottles[i])) {
						unfilled.Add (i);
					}	
					allWater -= (bottleCapacity-bottles[i]);
				}	
			}

			if (allWater>=0) {
				Console.WriteLine ("Enough water!");
				Console.WriteLine ("Water left: {0}l.", allWater);
			} else {
				Console.WriteLine ("We need more water!");
				Console.WriteLine ("Bottles left: {0}", unfilled.Count);
				Console.WriteLine ("With indexes: {0}", string.Join (", ", unfilled));
				Console.WriteLine ("We need {0} more liters!", Math.Abs (allWater) );

			}


		}
	}
}
