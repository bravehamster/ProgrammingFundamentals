using System.Numerics;
using System;

namespace DifferentIntegersSize
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			BigInteger num = BigInteger.Parse (Console.ReadLine ());
			string number = num.ToString();

			string canFitInto = "";

			try {
				sbyte numSbyte = sbyte.Parse(number);
				canFitInto += "\n * sbyte";
			} catch (Exception ex) {

			}


			try {
				byte numbyte = byte.Parse(number);
				canFitInto += "\n * byte";
			} catch (Exception ex) {

			}


			try {
				short numShort = short.Parse(number);
				canFitInto += "\n * short";
			} catch (Exception ex) {

			}


			try {
				ushort numUshort = ushort.Parse(number);
				canFitInto += "\n * ushort";
			} catch (Exception ex) {

			}


			try {
				int numInt = int.Parse(number);
				canFitInto += "\n * int";
			} catch (Exception ex) {

			}


			try {
				uint numUInt = uint.Parse(number);
				canFitInto += "\n * uint";
			} catch (Exception ex) {

			}
			try {
				long numUInt = long.Parse(number);
				canFitInto += "\n * long";
			} catch (Exception ex) {

			}

			if (canFitInto=="") {
				Console.WriteLine ($"{number} can't fit in any type");
			}else{
				Console.WriteLine (num + " can fit in:" + canFitInto);

			}



		}
	}
}
