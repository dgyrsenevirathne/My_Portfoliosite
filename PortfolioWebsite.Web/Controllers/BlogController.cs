using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
