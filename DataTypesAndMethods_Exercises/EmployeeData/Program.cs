using System;

namespace EmployeeData
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string fName = "Amanda";
			string lName = "Jonson";
			int age = 27;
			string gender = "f";
			long pid = 8306112507;
			long uid = 27563571;

			dataPrinter (fName, lName, age, gender, pid, uid);

		}

		public static void dataPrinter(string firstname, string lastname, int age, string gender, long personalID, long uniqueID)
		{
			Console.WriteLine ($"First name: {firstname}");
			Console.WriteLine ($"Last name: {lastname}");
			Console.WriteLine ($"Age: {age}");
			Console.WriteLine ($"Gender: {gender}");
			Console.WriteLine ($"Personal ID: {personalID}");
			Console.WriteLine ($"Unique Employee number: {uniqueID}");
			return;
		}
	}
}
