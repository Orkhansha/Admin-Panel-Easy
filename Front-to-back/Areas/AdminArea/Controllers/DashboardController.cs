using Microsoft.AspNetCore.Mvc;

namespace Front_to_back.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class DashboardController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
