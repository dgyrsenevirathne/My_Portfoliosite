using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.Web.Models;
using PortfolioWebsite.Web.Repository;


namespace PortfolioWebsite.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Send(ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _contactRepository.InsertContactMessageAsync(contactMessage);
                    ViewBag.Message = "Your message has been sent!";
                }
                catch (Exception ex)
                {
                    // Log exception details
                    ViewBag.Message = $"An error occurred while sending your message: {ex.Message}";
                }
                return View("Index");
            }
            return View("Index");
        }
    }
}
