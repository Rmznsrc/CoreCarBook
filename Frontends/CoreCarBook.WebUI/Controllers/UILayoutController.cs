using Microsoft.AspNetCore.Mvc;

namespace CoreCarBook.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
