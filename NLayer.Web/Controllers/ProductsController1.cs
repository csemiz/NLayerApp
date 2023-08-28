using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers
{
    public class ProductsController1 : Controller
    {
        private readonly IProductService _services;

        public ProductsController1(IProductService services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _services.GetProductWithCategory());
        }
    }
}
