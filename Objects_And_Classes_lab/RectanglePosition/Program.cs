using System;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		Rectangle a = Rectangle.readRectangle ();
		Rectangle b = Rectangle.readRectangle ();

		Console.WriteLine (Rectangle.isAInsideB (a, b)==true ? "inside" : "Not inside");
	}
}

class Rectangle
{
	public double left { get; set; }

	public double top { get; set; }

	public double width { get; set; }

	public double height { get; set; }


	public double right { 
		get { return left + this.width; } 
	}


	public double bot { 
		get { return top + this.height; } 
	}


	public static bool isAInsideB(Rectangle a, Rectangle b){
		bool inside = a.left >= b.left && a.right <= b.right && a.top >= b.top && a.bot <= b.bot;
		return inside;
	}

	public static Rectangle readRectangle(){
		double[] dims = Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ();
		Rectangle curr = new Rectangle ();
		curr.left = dims [0];
		curr.top = dims [1];
		curr.width = dims [2];
		curr.height = dims [3];
		return curr;
	}

}