using System;

class VolumeCylinder
{
	static void Main()
	{
		const double pi = 3.14159;
		Console.Write("Enter radius: ");
		double radius = double.Parse(Console.ReadLine());
		Console.Write("Enter height: ");
		double height = double.Parse(Console.ReadLine());
		double volume = pi* radius * radius * height;
		Console.WriteLine("Volume of cylinder: " + volume);
	}
}