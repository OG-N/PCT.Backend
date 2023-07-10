using Microsoft.AspNetCore.Mvc;
using PCT.Backend.Entities;
using PCT.Backend.Services;
using System.Data.Entity;

namespace PCT.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly ProductService _service;
        private readonly IConfiguration _configuration;

        public DashboardController(ProductService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        [HttpGet("")]
        public IActionResult GetALl()
        {
            try
            {
                List<Product> allproducts = _service.GetProducts().ToList();

                var summary = allproducts.GroupBy(x => x.CreateDate)
                            .Select(x => new
                            {
                                products = x.Count(),
                                Date = (DateTime)x.Key
                            }).ToList();

                Report report = new Report();
                report.AllRecords = allproducts.Count();
                report.Pending = allproducts.Where(x => x.Status == Status.Pending).Count();
                report.Approved = allproducts.Where(x => x.Status == Status.Approved).Count();
                report.Rejected = 0;
                report.ProductsChart = summary;
                return Ok(report);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
