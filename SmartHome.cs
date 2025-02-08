using System;

// Base class representing a Device
public class Device
{
    // Private fields for encapsulation
    private string deviceId;
    private string status;

    // Constructor to initialize device properties
    public Device(string deviceId, string status)
    {
        this.deviceId = deviceId;
        this.status = status;
    }

    // Public property for DeviceId
    public string DeviceId
    {
        get { return deviceId; }
        set { deviceId = value; }
    }

    // Public property for Status
    public string Status
    {
        get { return status; }
        set { status = value; }
    }

    // Virtual method to display device status
    public virtual string DisplayStatus()
    {
        return "Device ID: " + DeviceId + ", Status: " + Status;
    }
}

// Thermostat class inheriting from Device
public class Thermostat : Device
{
    // Private field specific to Thermostat
    private double temperatureSetting;

    // Constructor calling base class constructor
    public Thermostat(string deviceId, string status, double temperatureSetting) 
        : base(deviceId, status)
    {
        this.temperatureSetting = temperatureSetting;
    }

    // Public property for TemperatureSetting
    public double TemperatureSetting
    {
        get { return temperatureSetting; }
        set { temperatureSetting = value; }
    }

    // Override DisplayStatus to include temperature setting
    public override string DisplayStatus()
    {
        return base.DisplayStatus() + ", Temperature Setting: " + TemperatureSetting + "°C";
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        Thermostat thermostat = new Thermostat("TH001", "Active", 22.5);
        Console.WriteLine(thermostat.DisplayStatus());
    }
}