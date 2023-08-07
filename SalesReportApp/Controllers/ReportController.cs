using Microsoft.AspNetCore.Mvc;
using SalesReportApp.Repositories;
using SalesReportApp.Models;

namespace SalesReportApp.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository _repository;

        public ReportController(IReportRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> SalesByCountry()
        {
            try
            {
                var model = await _repository.GetSalesByCountry();

                if (model == null || model.Count == 0)
                {
                    return View("Error", new ErrorViewModel { RequestId = "No sales data available" });
                }

                return View(model);
            }
            catch (Exception ex)
            {
                // Log the exception here
                return View("Error", new ErrorViewModel { RequestId = ex.Message });
            }
        }
    }
}