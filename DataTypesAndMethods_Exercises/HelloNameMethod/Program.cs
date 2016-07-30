using System;

namespace HelloNameMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			helloName (Console.ReadLine ());

		}
		public static void helloName(string input){
			Console.WriteLine ($"Hello, {input}!");
		}
	}
}
