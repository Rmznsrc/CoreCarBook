using Microsoft.AspNetCore.Mvc;

namespace CoreCarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
