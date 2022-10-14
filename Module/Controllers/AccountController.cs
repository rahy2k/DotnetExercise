using Microsoft.AspNetCore.Mvc;
using Module.Models;

namespace Module.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult SignUp(UserModel model)
        {
           if(ModelState.IsValid)
            {
               // To Do.    
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
