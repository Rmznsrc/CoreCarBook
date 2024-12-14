using Microsoft.AspNetCore.Mvc;

namespace CoreCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCoverUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
