namespace Week8_Project;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    public double Weight { get; protected set; }

    protected DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract void CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Tracking number: {TrackingNumber}, Weight: {Weight}");
    }
}