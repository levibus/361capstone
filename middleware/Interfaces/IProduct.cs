namespace _361capstone
{
    public interface IProduct
    {
        int SKU { get; set; }
        string itemName { get; set; }
        float cost { get; set; }
        string manufacturer { get; set; }
        int categoryId { get; set; }
        string img { get; set; }
        int imgId { get; set; }

        float ApplyDiscount(int discount);
    }
}
