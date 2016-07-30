using System;

namespace CompareFloats
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num1 = float.Parse (Console.ReadLine ());
			double num2 = float.Parse (Console.ReadLine ());
			double diff = Math.Abs(num1 - num2);
			double eps = 0.0000009;
			if (diff>eps) {
				Console.WriteLine ("False");
			} else {
				Console.WriteLine ("True");
			}
		}
	}
}
