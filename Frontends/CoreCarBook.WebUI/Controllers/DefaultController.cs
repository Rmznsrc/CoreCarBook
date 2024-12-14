using Microsoft.AspNetCore.Mvc;

namespace CoreCarBook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
