using System;

// Interface defining refueling behavior
public interface IRefuelable
{
    // Method to be implemented by classes
    string Refuel();
}

// Base class representing a Vehicle
public abstract class Vehicle
{
    // Private fields for encapsulation
    private int maxSpeed;
    private string model;

    // Constructor to initialize vehicle properties
    public Vehicle(int maxSpeed, string model)
    {
        this.maxSpeed = maxSpeed;
        this.model = model;
    }

    // Public property for MaxSpeed
    public int MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    // Public property for Model
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    // Virtual method to display vehicle information
    public virtual string DisplayInfo()
    {
        return "Model: " + Model + ", Max Speed: " + MaxSpeed + " km/h";
    }
}

// ElectricVehicle class inheriting from Vehicle
public class ElectricVehicle : Vehicle
{
    // Private fields specific to ElectricVehicle
    private int batteryCapacity;
    private int currentCharge;

    // Constructor calling base class constructor
    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity) 
        : base(maxSpeed, model)
    {
        this.batteryCapacity = batteryCapacity;
        this.currentCharge = batteryCapacity;
    }

    // Method to charge the electric vehicle
    public string Charge()
    {
        this.currentCharge = batteryCapacity;
        return "Vehicle charged to " + currentCharge + " kWh";
    }

    // Override DisplayInfo to include electric vehicle information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", Battery Capacity: " + batteryCapacity + " kWh, Current Charge: " + currentCharge + " kWh";
    }
}

// PetrolVehicle class inheriting from Vehicle and implementing IRefuelable
public class PetrolVehicle : Vehicle, IRefuelable
{
    // Private fields specific to PetrolVehicle
    private int fuelCapacity;
    private int currentFuel;

    // Constructor calling base class constructor
    public PetrolVehicle(int maxSpeed, string model, int fuelCapacity) 
        : base(maxSpeed, model)
    {
        this.fuelCapacity = fuelCapacity;
        this.currentFuel = fuelCapacity;
    }

    // Implementation of IRefuelable interface method
    public string Refuel()
    {
        this.currentFuel = fuelCapacity;
        return "Vehicle refueled to " + currentFuel + " liters";
    }

    // Override DisplayInfo to include petrol vehicle information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", Fuel Capacity: " + fuelCapacity + " liters, Current Fuel: " + currentFuel + " liters";
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        ElectricVehicle ev = new ElectricVehicle(200, "Tesla Model 3", 75);
        PetrolVehicle pv = new PetrolVehicle(180, "Toyota Camry", 50);

        Console.WriteLine("Electric Vehicle:");
        Console.WriteLine(ev.DisplayInfo());
        Console.WriteLine("Charging: " + ev.Charge());
        Console.WriteLine();
        Console.WriteLine("Petrol Vehicle:");
        Console.WriteLine(pv.DisplayInfo());
        Console.WriteLine("Refueling: " + pv.Refuel());
    }
}