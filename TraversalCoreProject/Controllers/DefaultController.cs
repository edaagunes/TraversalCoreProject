using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {

		public IActionResult Index()
        {
			var newsletter = new Newsletter(); // veya veritabanından alınan Newsletter verisi
			ViewData["Newsletter"] = newsletter; // Bu şekilde ViewData ile geçebilirsiniz
			return View();
		}

        
    }
}
