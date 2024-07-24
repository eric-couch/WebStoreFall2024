
namespace WebStoreFall2024.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Addess { get; set; }
    public string? Phone { get; set; }

    // navagation property
    public ICollection<Order> Orders { get; set; } = null!;
}

