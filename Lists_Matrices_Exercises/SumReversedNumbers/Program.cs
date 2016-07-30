using System;
using System.Linq;

namespace SumReversedNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] inputArr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			double sum = 0;
			for (int i = 0; i < inputArr.Length; i++) {
				//Console.WriteLine (reverseNumbers (inputArr[i]));
				sum += reverseNumbers (inputArr[i]);
			}
			Console.WriteLine (sum);

		}

		static int reverseNumbers(int num){
			int right = 0;
			int reversed = 0;
			while (num>0) {
				right = (int)num % 10;
				reversed = reversed * 10 + right;
				num /= 10;
			}
			return reversed;
		}
	}

}
