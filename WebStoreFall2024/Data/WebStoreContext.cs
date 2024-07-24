using Microsoft.EntityFrameworkCore;
using WebStoreFall2024.Models;

namespace WebStoreFall2024.Data;

public class WebStoreContext : DbContext
{
    public WebStoreContext()
    {
    }

    public WebStoreContext(DbContextOptions<WebStoreContext> options) : base(options) { 
    }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    public virtual DbSet<Product> Products { get; set; }


}
