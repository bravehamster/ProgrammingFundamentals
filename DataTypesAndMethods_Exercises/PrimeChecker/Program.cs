using System;

namespace PrimeChecker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long n = long.Parse (Console.ReadLine ());
			if (isPrime (n)) {
				Console.WriteLine ("True");
			} else {
				Console.WriteLine ("False");
			}
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
