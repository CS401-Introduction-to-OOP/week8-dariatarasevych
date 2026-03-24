namespace Week8_Project;

public class CargoContainer <T> where T:DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
        Console.WriteLine($"Added: {item.TrackingNumber}");
    }

    public double GetTotalCost()
    {
        foreach (var item in _items)
        {
            item.CalculateCost();
        }

        return GetTotalCost();
    }
}