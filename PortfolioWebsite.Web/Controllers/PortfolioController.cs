using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Web.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
