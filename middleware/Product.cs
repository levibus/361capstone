namespace _361capstone;

public class Product
{
    public int SKU { get; set; }
    public string itemName { get; set; }
    public float cost { get; set; }
    public string manufacturer { get; set; }
    public int categoryCode { get; set; }

    public Product(int SKU, string itemName, float cost, string manufacturer, int categoryCode)
    {
        this.SKU = SKU;
        this.itemName = itemName;
        this.cost = cost;
        this.manufacturer = manufacturer;
        this.categoryCode = categoryCode;
    }

    public float ApplyDiscount(int discount)
    {
        return discount * cost;
    }
}