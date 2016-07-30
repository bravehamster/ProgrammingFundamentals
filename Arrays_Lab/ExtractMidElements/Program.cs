using System;
using System.Linq;
namespace ExtractMidElements
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			int n = arr.Length;
			if (n==1) {
				Console.WriteLine ("{{ {0} }}", arr[0]);
			}else if (n%2==0) {
				Console.WriteLine ("{{ {0}, {1} }}", arr[n/2 -1], arr[n/2]);
			}else {
				Console.WriteLine ("{{ {0}, {1}, {2} }}", arr[n/2 -1], arr[n/2], arr[n/2 +1]);
			}
		}
	}
}
