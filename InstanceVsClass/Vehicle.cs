using System;

namespace VehicleRegistrationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create multiple vehicles
            Vehicle car = new Vehicle("John Doe", "Car");
            Vehicle motorcycle = new Vehicle("Jane Smith", "Motorcycle");
            Vehicle truck = new Vehicle("Bob Johnson", "Truck");

            // Display initial vehicle details
            Console.WriteLine("Initial Vehicle Details:");
            car.DisplayVehicleDetails();
            motorcycle.DisplayVehicleDetails();
            truck.DisplayVehicleDetails();

            // Update registration fee
            Console.WriteLine("\nUpdating Registration Fee...");
            Vehicle.UpdateRegistrationFee(150.00);

            // Display updated vehicle details
            Console.WriteLine("\nUpdated Vehicle Details:");
            car.DisplayVehicleDetails();
            motorcycle.DisplayVehicleDetails();
            truck.DisplayVehicleDetails();
        }
    }

    public class Vehicle
    {
        // Instance variables
        private string ownerName;
        private string vehicleType;

        // Static variable (class variable)
        private static double registrationFee = 100.00;

        // Constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // Public properties
        public string OwnerName
        {
            get { return ownerName; }
            private set { ownerName = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            private set { vehicleType = value; }
        }

        // Instance method to display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("\nVehicle Details:");
            Console.WriteLine("Owner Name: " + ownerName); 
            Console.WriteLine("Vehicle Type: " + vehicleType); 
            Console.WriteLine("Registration Fee: $" + registrationFee.ToString("F2")); 
        }

        // Static method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            if (newFee > 0)
            {
                registrationFee = newFee;
                Console.WriteLine("Registration fee updated to: $" + registrationFee.ToString("F2")); 
            }
            else
            {
                Console.WriteLine("Invalid registration fee amount.");
            }
        }

        // Static method to get current registration fee
        public static double GetRegistrationFee()
        {
            return registrationFee;
        }
    }
}
