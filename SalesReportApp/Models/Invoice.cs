namespace SalesReportApp.Models;

public class Invoice
{
    public int InvoiceId { get; set; }
    public int CustomerId { get; set; }
    public decimal Total { get; set; }
    public virtual Customer Customer { get; set; }
}
