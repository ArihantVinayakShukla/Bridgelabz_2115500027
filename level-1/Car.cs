using System;

namespace CarRentalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create rental bookings
            CarRental defaultRental = new CarRental();
            CarRental customRental = new CarRental("Alice Johnson", "Toyota Camry", 5);

            // Display rental information
            Console.WriteLine("Default Rental:");
            defaultRental.DisplayInfo();

            Console.WriteLine("\nCustom Rental:");
            customRental.DisplayInfo();
        }
    }

    public class CarRental
    {
        // Private fields for encapsulation
        private string customerName;
        private string carModel;
        private int rentalDays;
        private readonly double baseRate = 50.00;

        // Default constructor
        public CarRental()
        {
            this.customerName = "Not Specified";
            this.carModel = "Standard";
            this.rentalDays = 1;
        }

        // Parameterized constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        // Public properties with controlled access
        public string CustomerName
        {
            get { return customerName; }
            private set { customerName = value; }
        }

        public string CarModel
        {
            get { return carModel; }
            private set { carModel = value; }
        }

        public int RentalDays
        {
            get { return rentalDays; }
            private set { rentalDays = value; }
        }

        // Method to calculate rental cost
        public double CalculateTotalCost()
        {
            double modelRate = GetModelRate();
            return modelRate * rentalDays;
        }

        // Private method to determine rate based on car model
        private double GetModelRate()
        {
            switch (carModel.ToLower())
            {
                case "luxury":
                    return baseRate * 2.0;
                case "suv":
                    return baseRate * 1.5;
                default:
                    return baseRate;
            }
        }

        // Method to extend rental
        public void ExtendRental(int additionalDays)
        {
            if (additionalDays > 0)
            {
                rentalDays += additionalDays;
                Console.WriteLine("Rental extended by " + additionalDays + " days.");
            }
            else
            {
                Console.WriteLine("Invalid number of days for extension.");
            }
        }

        // Method to display rental information
        public void DisplayInfo()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Car Model: " + carModel);
            Console.WriteLine("Rental Duration: " + rentalDays + " days");
            Console.WriteLine("Total Cost: $" + CalculateTotalCost().ToString("F2"));
        }
    }
}
