using Microsoft.AspNetCore.Mvc;

namespace Module.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
