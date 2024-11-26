using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.Controllers
{
	[AllowAnonymous]
	public class AboutController : Controller
	{
		private readonly IGuideService _guideService;

		public AboutController(IGuideService guideService)
		{
			_guideService = guideService;
		}

		public IActionResult Index()
		{
			var values=_guideService.TGetList().Take(4);
			return View(values);
		}
	}
}
