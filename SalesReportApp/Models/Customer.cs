namespace SalesReportApp.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string Country { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; }
}
