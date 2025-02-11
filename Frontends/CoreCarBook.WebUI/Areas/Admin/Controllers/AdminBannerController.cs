﻿using Microsoft.AspNetCore.Mvc;

namespace CoreCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
