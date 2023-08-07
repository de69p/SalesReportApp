using Microsoft.EntityFrameworkCore;

namespace SalesReportApp.Models;

public class ChinookContext : DbContext
{
    public ChinookContext(DbContextOptions<ChinookContext> options) : base(options) {}

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
}
