using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		int numPtsToRead = int.Parse (Console.ReadLine ());
		Point[] ptArray = new Point[numPtsToRead];
		for (int i = 0; i < numPtsToRead; i++) {
			double[] input = Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ();
			ptArray[i] = Point.SetPointAttrs (input);
		}

		Point[] closestPaiir = Point.findClosestPairInArray (ptArray);

		Console.WriteLine ("{0:f3}", Point.findEuclideanDistanceBetweenPoints (closestPaiir[0], closestPaiir[1]));

		foreach (var point in closestPaiir) {
			Console.WriteLine ("({0}, {1})", point.px, point.py);
		}

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


	public static Point[] findClosestPairInArray(Point[] arr){
		Point[] closestPair = new Point[2];
		double closestPairDist = double.MaxValue;
		for (int i = 0; i < arr.Length; i++) {
			for (int j = i+1; j < arr.Length; j++) {
				double dist = findEuclideanDistanceBetweenPoints (arr [i], arr [j]);
				if (dist < closestPairDist) {
					closestPair [0] = arr [i];
					closestPair [1] = arr [j];
					closestPairDist = dist;
				}
			}
		}

		return closestPair;
	}






}