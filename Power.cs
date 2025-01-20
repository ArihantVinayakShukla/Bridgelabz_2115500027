using System; 

class Power
{
	static void Main()
	{
		Console.Write("Enter base: ");
		double baseNum = double.Parse(Console.ReadLine());
		Console.Write("Enter exponent: ");
		double exponent = double.Parse(Console.ReadLine());
		double result = Math.Pow(baseNum, exponent);
		Console.WriteLine("Result: " + result);
	}
}