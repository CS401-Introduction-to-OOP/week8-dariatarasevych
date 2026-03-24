namespace Week8_Project;

public class Parcel : DeliveryItem
{
    public string Dimensions = "30x20x15";
    
    public Parcel(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        Dimensions = "30x20x15";
    }
   

    public override double CalculateCost()
    {
        return 50 + (Weight * 25);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}");
    }
}