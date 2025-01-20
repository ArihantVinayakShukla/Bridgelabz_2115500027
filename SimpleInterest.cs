using System;

class SimpleInterest
{
	static void Main()
	{
		Console.Write("Enter the Principal amount: ");
		double principal = double.Parse(Console.ReadLine());
		Console.Write("Enter Rate of interest: ");
		double rate = double.Parse(Console.ReadLine());
		Console.Write("Enter Time (in years): ");
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest: " + simpleInterest);
    }
}