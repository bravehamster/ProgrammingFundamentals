using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{


		int n = int.Parse (Console.ReadLine ());
		List<Student> students = new List<Student> ();

		for (int i = 0; i < n; i++) {
			List<string> input = Console.ReadLine ().Split (' ').ToList ();

			Student curr = new Student (){ name = input [0], grades = parseStringListToDoubleList (input) };
			students.Add (curr);
		}


		List<Student> sortedStudents = students.OrderBy (x => -x.averageGrade).OrderBy (x=> x.name).ToList ();


		foreach (var student in sortedStudents) {
			if (student.averageGrade>=5.00) {
				Console.WriteLine ("{0} -> {1:f2}", student.name, student.averageGrade);
			}
		}

	

	}

	public static List<double> parseStringListToDoubleList(List<string> lst){
		List<double> curr = new List<double> ();
		lst.RemoveAt (0);
		foreach (var item in lst) {
			curr.Add (double.Parse (item));
		}
		return curr;
	}
}


class Student
{
	public string name {
		get;
		set;
	}

	public List<double> grades {
		get;
		set;
	}

	public double averageGrade {
		get
		{
			return grades.Average ();
		}
	}



}
