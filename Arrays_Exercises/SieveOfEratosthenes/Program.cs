using System;

namespace SieveOfEratosthenes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool[] primes = new bool[int.Parse(Console.ReadLine())+1];
			for (int i = 0; i < primes.Length; i++) {
				primes [i] = true;
			}
			primes [0] = primes [1] = false;


			for (int i = 2; i < primes.Length; i++) {
				if (primes[i]==true) {
					Console.Write (i + " ");
					for (int k = 2; i*k < primes.Length; k++) {
						primes [i * k] = false;
					}
				}

			}
		}
	}
}
