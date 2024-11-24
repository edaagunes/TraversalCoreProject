using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        [Area("Member")]
        [AllowAnonymous]
		[Route("Member/[controller]/[action]/{id?}")]
		public IActionResult Index()
        {
			ViewData["PageTitle"] = "Yorumlar";

			return View();
        }
    }
}
