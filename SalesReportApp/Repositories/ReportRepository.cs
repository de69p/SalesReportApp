using Microsoft.EntityFrameworkCore;
using SalesReportApp.Models;


namespace SalesReportApp.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ChinookContext _context;

        public ReportRepository(ChinookContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, decimal>> GetSalesByCountry()
        {
            return await _context.Customers
                .GroupBy(c => c.Country)
                .Select(g => new { Country = g.Key, Total = g.Sum(c => c.Invoices.Sum(i => i.Total)) })
                .ToDictionaryAsync(x => x.Country, x => x.Total);
        }
    }
}

