using System;

// Base class representing an Order
public class Order
{
    // Private fields for encapsulation
    private string orderId;
    private DateTime orderDate;

    // Constructor to initialize order properties
    public Order(string orderId, DateTime orderDate)
    {
        this.orderId = orderId;
        this.orderDate = orderDate;
    }

    // Public property for OrderId
    public string OrderId
    {
        get { return orderId; }
        set { orderId = value; }
    }

    // Public property for OrderDate
    public DateTime OrderDate
    {
        get { return orderDate; }
        set { orderDate = value; }
    }

    // Virtual method to get order status
    public virtual string GetOrderStatus()
    {
        return "Order Status: Placed - Order ID: " + OrderId + ", Order Date: " + OrderDate.ToShortDateString();
    }
}

// ShippedOrder class inheriting from Order
public class ShippedOrder : Order
{
    // Private field specific to ShippedOrder
    private string trackingNumber;

    // Constructor calling base class constructor
    public ShippedOrder(string orderId, DateTime orderDate, string trackingNumber) 
        : base(orderId, orderDate)
    {
        this.trackingNumber = trackingNumber;
    }

    // Public property for TrackingNumber
    public string TrackingNumber
    {
        get { return trackingNumber; }
        set { trackingNumber = value; }
    }

    // Override GetOrderStatus to include tracking information
    public override string GetOrderStatus()
    {
        return base.GetOrderStatus() + ", Tracking Number: " + TrackingNumber;
    }
}

// DeliveredOrder class inheriting from ShippedOrder
public class DeliveredOrder : ShippedOrder
{
    // Private field specific to DeliveredOrder
    private DateTime deliveryDate;

    // Constructor calling base class constructor
    public DeliveredOrder(string orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) 
        : base(orderId, orderDate, trackingNumber)
    {
        this.deliveryDate = deliveryDate;
    }

    // Public property for DeliveryDate
    public DateTime DeliveryDate
    {
        get { return deliveryDate; }
        set { deliveryDate = value; }
    }

    // Override GetOrderStatus to include delivery information
    public override string GetOrderStatus()
    {
        return base.GetOrderStatus() + ", Delivery Date: " + DeliveryDate.ToShortDateString();
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order("ORD001", DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder("ORD002", DateTime.Now, "TRK123");
        DeliveredOrder deliveredOrder = new DeliveredOrder("ORD003", DateTime.Now, "TRK456", DateTime.Now.AddDays(5));

        Console.WriteLine(order.GetOrderStatus());
        Console.WriteLine(shippedOrder.GetOrderStatus());
        Console.WriteLine(deliveredOrder.GetOrderStatus());
    }
}