using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int startNum = int.Parse (Console.ReadLine ());
			int endNum = int.Parse (Console.ReadLine ());

			List<int> myList = FindPrimesInRange (startNum, endNum);

			for (int i = 0; i < myList.Count-1; i++) {
				Console.Write (myList[i] + ", ");
			}
			Console.Write (myList[myList.Count-1]);
		}

		public static List<int> FindPrimesInRange(int start, int end)
		{
			List<int> primesList = new List<int>();
			for (int i = start; i <= end; i++) {
				if (isPrime(i)) {
					primesList.Add(i);
				}	
			}
			return primesList;

		}
		public static bool isPrime(long num){

			bool isPrime = false;

			if (num==2||num==3) {
				isPrime = true;
			}
			if ((num + 1) % 6 == 0) {
				for (int i = 2; i <= Math.Sqrt(num); i++) {
					isPrime = true;
					if (num%i==0) {
						isPrime = false;
						break;
					}
				}

			} else if ((num - 1) % 6 == 0) {
				for (int i = 2; i <= Math.Sqrt(num); i++) {
					isPrime = true;
					if (num%i==0) {
						isPrime = false;
						break;
					}
				}
			} 
			return isPrime;

		}
	}
}
