using System;

class PerimeterRectangle
{
	static void Main()
	{
		Console.Write("Enter Length: ");
		double length = double.Parse(Console.ReadLine());
		Console.Write("Enter width: ");
		double width = double.Parse(Console.ReadLine());
		double perimeter = 2 * ( length + width );
		Console.WriteLine("Perimeter of Rectangle: " + perimeter);
	}
}