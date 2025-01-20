using System;

class AreaCircle
{
	static void Main()
	{
		const double pi = 3.14159;
		Console.Write("Enter radius: ");
		double radius = double.Parse(Console.ReadLine());
		double area = pi * radius *radius;
		Console.WriteLine("Area of Circle: " + area);
	}
}