using System;

namespace HotelBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create bookings using different constructors
            HotelBooking defaultBooking = new HotelBooking();
            HotelBooking customBooking = new HotelBooking("Jane Smith", "Deluxe", 3);
            HotelBooking copyBooking = new HotelBooking(customBooking);

            // Display bookings
            Console.WriteLine("Default Booking:");
            defaultBooking.DisplayInfo();

            Console.WriteLine("\nCustom Booking:");
            customBooking.DisplayInfo();

            Console.WriteLine("\nCopied Booking:");
            copyBooking.DisplayInfo();
        }
    }

    public class HotelBooking
    {
        // Private fields for encapsulation
        private string guestName;
        private string roomType;
        private int nights;
        private readonly double baseRate = 100.00;

        // Default constructor
        public HotelBooking()
        {
            // Assign default values
            this.guestName = "Not Specified";
            this.roomType = "Standard";
            this.nights = 1;
        }

        // Parameterized constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            // Assign provided values to fields
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy constructor
        public HotelBooking(HotelBooking other)
        {
            // Copy values from another HotelBooking object
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        // Public properties with controlled access
        public string GuestName
        {
            // Get the guest name
            get { return guestName; }
            // Private setter to prevent modification outside class
            private set { guestName = value; }
        }

        public string RoomType
        {
            // Get the room type
            get { return roomType; }
            // Private setter to prevent modification outside class
            private set { roomType = value; }
        }

        public int Nights
        {
            // Get the number of nights
            get { return nights; }
            // Private setter to prevent modification outside class
            private set { nights = value; }
        }

        // Method to calculate total cost
        public double CalculateTotalCost()
        {
            // Determine room rate based on type
            double roomRate = roomType.ToLower() == "deluxe" ? baseRate * 1.5 : baseRate;
            return roomRate * nights;
        }

        // Method to display booking information
        public void DisplayInfo()
        {
            // Print booking details using string concatenation
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Number of Nights: " + nights);
            Console.WriteLine("Total Cost: $" + CalculateTotalCost().ToString("F2"));
        }
    }
}
