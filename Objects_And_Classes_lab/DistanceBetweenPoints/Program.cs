using System;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		Point pt1 = Point.SetPointAttrs (Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ());
		Point pt2 = Point.SetPointAttrs (Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ());
		Console.WriteLine ("{0:f3}", Point.findEuclideanDistanceBetweenPoints (pt1, pt2));

	}
}

class Point
{
	public double px {
		get;
		set;
	}

	public double py {
		get;
		set;
	}



	public static double findEuclideanDistanceBetweenPoints(Point p1, Point p2){
		double x = p1.px - p2.px;
		double y = p1.py - p2.py;
		return Math.Sqrt ((x * x) + (y * y));
	}

	public static Point SetPointAttrs(double[] xyDimensions ){
		Point curr = new Point ();
		curr.px = xyDimensions [0];
		curr.py = xyDimensions [1];
		return curr;
	}

}

