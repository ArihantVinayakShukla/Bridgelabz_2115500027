using System;

// Base class for all vehicles
public abstract class Vehicle
{
    // Private fields for encapsulation
    private int maxSpeed;
    private string fuelType;

    // Constructor to initialize vehicle properties
    public Vehicle(int maxSpeed, string fuelType)
    {
        this.maxSpeed = maxSpeed;
        this.fuelType = fuelType;
    }

    // Public properties with getters and setters
    public int MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    public string FuelType
    {
        get { return fuelType; }
        set { fuelType = value; }
    }

    // Virtual method for displaying vehicle information
    public virtual string DisplayInfo()
    {
        return "Max Speed: " + MaxSpeed + " km/h, Fuel Type: " + FuelType;
    }
}

// Car class inheriting from Vehicle
public class Car : Vehicle
{
    // Additional property specific to Car
    private int seatCapacity;

    // Constructor calling base class constructor
    public Car(int maxSpeed, string fuelType, int seatCapacity) 
        : base(maxSpeed, fuelType)
    {
        this.seatCapacity = seatCapacity;
    }

    // Property for SeatCapacity
    public int SeatCapacity
    {
        get { return seatCapacity; }
        set { seatCapacity = value; }
    }

    // Override DisplayInfo to include Car-specific information
    public override string DisplayInfo()
    {
        return "Car - " + base.DisplayInfo() + ", Seat Capacity: " + SeatCapacity;
    }
}

// Truck class inheriting from Vehicle
public class Truck : Vehicle
{
    // Additional property specific to Truck
    private int payloadCapacity;

    // Constructor calling base class constructor
    public Truck(int maxSpeed, string fuelType, int payloadCapacity) 
        : base(maxSpeed, fuelType)
    {
        this.payloadCapacity = payloadCapacity;
    }

    // Property for PayloadCapacity
    public int PayloadCapacity
    {
        get { return payloadCapacity; }
        set { payloadCapacity = value; }
    }

    // Override DisplayInfo to include Truck-specific information
    public override string DisplayInfo()
    {
        return "Truck - " + base.DisplayInfo() + ", Payload Capacity: " + PayloadCapacity + " kg";
    }
}

// Motorcycle class inheriting from Vehicle
public class Motorcycle : Vehicle
{
    // Additional property specific to Motorcycle
    private bool hasSidecar;

    // Constructor calling base class constructor
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) 
        : base(maxSpeed, fuelType)
    {
        this.hasSidecar = hasSidecar;
    }

    // Property for HasSidecar
    public bool HasSidecar
    {
        get { return hasSidecar; }
        set { hasSidecar = value; }
    }

    // Override DisplayInfo to include Motorcycle-specific information
    public override string DisplayInfo()
    {
        return "Motorcycle - " + base.DisplayInfo() + ", Has Sidecar: " + HasSidecar;
    }
}

// Main Program to demonstrate the functionality
class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(200, "Petrol", 5),
            new Truck(160, "Diesel", 5000),
            new Motorcycle(180, "Petrol", false)
        };

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle.DisplayInfo());
        }
    }
}
