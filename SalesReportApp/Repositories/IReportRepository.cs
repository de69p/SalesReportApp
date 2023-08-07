namespace SalesReportApp.Repositories;

public interface IReportRepository
{
    Task<Dictionary<string, decimal>> GetSalesByCountry();
}