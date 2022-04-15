using Microsoft.AspNetCore.Mvc;

namespace Bonbon_Ecommerce.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
