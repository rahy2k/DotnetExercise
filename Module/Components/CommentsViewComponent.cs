using Microsoft.AspNetCore.Mvc;

namespace Module.Components
{
    public class CommentsViewComponent:ViewComponent

    {
        public IViewComponentResult Invoke(int id)
        {
            // TO DO:
            List<string> list = new List<string> { "Good", "Great", "Keep it up" };


            return View("~/views/components/_Comments.cshtml", list);
        }
    }
}
