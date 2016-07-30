using System;
using System.Linq;
namespace ShortWordsSorted
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] split = new char[]{ '.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '!', '?', ' '};
			string[] arr = Console.ReadLine ().ToLower ().Split (split);
			string[] output = arr.Distinct ().OrderBy (x => x).ToArray ();

			Console.WriteLine (string.Join (", ",output.Where (x=>x.Length<5 && x!="")));


		}
	}
}
