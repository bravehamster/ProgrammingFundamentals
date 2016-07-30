using System;
using System.Linq;
using System.Reflection;

class MainClass
{
	public static void Main (string[] args)
	{
		decimal[] inpA = Console.ReadLine ().Split (' ').Select (decimal.Parse).ToArray ();
		decimal[] inpB = Console.ReadLine ().Split (' ').Select (decimal.Parse).ToArray ();


		Point a = new Point (){X=inpA[0], Y = inpA[1]};
		Point b = new Point (){X=inpB[0], Y = inpB[1]};
	
		Circle firstCircle = new Circle (){center = a, rad = inpA[2] };
		Circle secondCircle = new Circle (){center = b, rad = inpB[2] };

		Console.WriteLine (doesAIntersectB (firstCircle, secondCircle)==true ? "Yes" : "No");

			
	}

	static bool doesAIntersectB(Circle a, Circle b){
		double distBetweenCenters = Point.findEuclideanDistance (a.center, b.center);
		if (distBetweenCenters <= (double)(a.rad+b.rad)) {
			return true;
		}
		return false;

	}
}

class Point
{
	public decimal X {
		get;
		set;
	}

	public decimal Y {
		get;
		set;
	}

	public static double findEuclideanDistance(Point a, Point b){
		decimal lenX = a.X - b.X;
		decimal lenY = a.Y - b.Y;

		return Math.Sqrt ((double)((lenX * lenX) + (lenY * lenY)));
	}


}


class Circle
{
	public Point center {
		get;
		set;
	}

	public decimal rad {
		get;
		set;
	}
}