using Microsoft.AspNetCore.Mvc;

namespace CoreCarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecomeADriverComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
