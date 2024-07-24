namespace WebStoreFall2024.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime? OrderFullfilled { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; } = null!;
    public ICollection<OrderDetail> Details { get; set; } = null!;

}
