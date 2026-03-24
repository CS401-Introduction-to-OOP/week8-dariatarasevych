namespace Week8_Project;

public class Letter: DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
    }
    public override void CalculateCost()
    {
        int fixedPrice = 15;
        Console.WriteLine($"Cost: {fixedPrice + Weight * 10}");
    }
}