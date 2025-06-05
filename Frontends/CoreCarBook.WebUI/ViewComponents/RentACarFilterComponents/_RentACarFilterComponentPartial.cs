using Microsoft.AspNetCore.Mvc;

namespace CoreCarBook.WebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarFilterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke(string v)
        {
           TempData["value"] = v;
            return View();
        }
    }
}
