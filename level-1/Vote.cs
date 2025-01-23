using System;

class Vote{

	static void Main(string[] args){
	
		//Take input and convert into integer
		int age = Convert.ToInt32(Console.ReadLine());
		//call the method to calculate age
		Console.WriteLine(CalculateAge(age));
		
	}
	
	// method to calculate age for voting
	static string CalculateAge(int age){
		
		//if-else statement to calculate if the person can vote or not
		if(age >=18 ){
			return ("The person's age is " + age +" and can vote");
		} else {
			return ("The person's age is " + age +" and cannot vote");
		}
	
	}

}