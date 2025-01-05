using CoreCarBook.Dto.ServiceDtos; 
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreCarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    { 
        public IActionResult Index()
        {
         
            
            return View();
        }
    }
}
