using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
