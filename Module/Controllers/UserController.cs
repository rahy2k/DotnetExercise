using Microsoft.AspNetCore.Mvc;
using Module.Models;

namespace Module.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login(LoginModel model)
        {
            if (model.Password == "USER")
            {
                return RedirectToAction("Dashboard", "User");
            }


            return View();
        }
        [Route("User/Index/Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [Route("User/Index/Profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
