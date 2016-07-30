using System;
using System.Linq;
namespace CensorYourEmailAddress
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] emailAddress = Console.ReadLine ().Split ('@');
			string text = Console.ReadLine ();

			string edited = new string('*', emailAddress [0].Length) + "@" + emailAddress [1];

			text = text.Replace (emailAddress[0] + "@" + emailAddress[1], edited);

			Console.WriteLine (text);

		}
	}
}
