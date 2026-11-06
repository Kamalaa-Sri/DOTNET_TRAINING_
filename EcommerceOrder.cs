using System;
abstract class Order
{
    public int OrderId;
    public string CustomerName;
    public double OrderAmount;
    public double Distance;
    public abstract double CalculateDeliveryCharge();
    public double CalculateFinalAmount()
    {
        return OrderAmount + CalculateDeliveryCharge();
    }
    public void DisplayDetails(string deliveryType)
    {
        Console.WriteLine("Order ID: " + OrderId);
        Console.WriteLine("Customer: " + CustomerName);
        Console.WriteLine("Order Amount: " + OrderAmount);
        Console.WriteLine("Delivery Type: " + deliveryType);
        Console.WriteLine("Distance: " + Distance + " km");
        Console.WriteLine("Delivery Charge: " + CalculateDeliveryCharge());
        Console.WriteLine("Final Amount: " + CalculateFinalAmount());
    }
}
class StandardDelivery : Order
{
    public override double CalculateDeliveryCharge()
    {
        if (OrderAmount > 2000)
            return 0;

        return Distance * 10;
    }
}
class ExpressDelivery : Order
{
    public override double CalculateDeliveryCharge()
    {
        return (Distance * 20) + 50;
    }
}
class SameDayDelivery : Order
{
    public override double CalculateDeliveryCharge()
    {
        return (Distance * 30) + 100;
    }
}
class EcommerceOrder
{
    static void Main(string[] args)
    {
        ExpressDelivery ob = new ExpressDelivery();

        Console.WriteLine("Enter Order ID:");
        ob.OrderId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Customer Name:");
        ob.CustomerName = Console.ReadLine();

        Console.WriteLine("Enter Order Amount:");
        ob.OrderAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Distance:");
        ob.Distance = Convert.ToDouble(Console.ReadLine());

        if (ob.OrderAmount < 0 || ob.Distance < 0)
        {
            Console.WriteLine("Invalid Order Amount or Distance!");
        }
        else
        {
            ob.DisplayDetails("Express");
        }
    }
}
