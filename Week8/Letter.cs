namespace Week8_Project;

public class Letter: DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
    }
    public override double CalculateCost()
    {
        int fixedPrice = 15;
        return fixedPrice + Weight * 10;
    }
}