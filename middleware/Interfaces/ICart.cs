namespace _361capstone.Models
{
    public interface ICart
    {
        int cartId { get; set; }
        int customerId { get; set; }
        int SKU { get; set; }
        int Quantity { get; set; }
    }
}