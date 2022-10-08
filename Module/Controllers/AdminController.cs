using Microsoft.AspNetCore.Mvc;
using Module.Models;

namespace Module.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Login(LoginModel model)
        {

            if (model.Password == "ADMIN")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            
            return View();
        }
        [Route("Admin/Index/Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [Route("Admin/Index/Profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
