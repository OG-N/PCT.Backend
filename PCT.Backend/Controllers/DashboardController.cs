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
        private readonly ProductService _productService;
        private readonly CarrierService _carrierService;
        private readonly CategoryService _categoryService;
        private readonly LocationService _locationService;
        private readonly UnitService _unitService;
        private readonly VendorService _vendorService;
        private readonly IConfiguration _configuration;

        public DashboardController(ProductService productService, 
            CarrierService carrierService,
            CategoryService categoryService,
            LocationService locationService,
            UnitService unitService,
            VendorService vendorService,
            IConfiguration configuration)
        {
            _productService = productService;
            _carrierService = carrierService;
            _categoryService = categoryService;
            _locationService = locationService;
            _unitService = unitService;
            _vendorService = vendorService;
            _configuration = configuration;
        }

        [HttpGet("")]
        public IActionResult GetALl()
        {
            try
            {
                var summary = from p in _productService.GetProducts()
                              group p by p.CreateDate.GetValueOrDefault().Date into g
                              orderby g.Key
                              select new { CreateDate = g.Key, Count = g.Count() };

                Report report = new Report();
                report.AllRecords = _productService.GetAllCount();
                report.Pending = _productService.GetPendingCount();
                report.Approved = _productService.GetApprovedCount();
                report.Rejected = _productService.GetRjectedCount();
                report.Products = _productService.GetAllCount();
                report.Locations =_locationService.GetCount();
                report.Stakeholders = 0;
                report.Transport = 0;
                report.Carriers = _carrierService.GetCount();
                report.UnitsOfMeasure = _unitService.GetCount();
                report.Categories = _categoryService.GetCount();
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
