using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
	[AllowAnonymous]
	public class NewsletterController : Controller
	{
		private readonly INewsletterService _newsletterService;

		public NewsletterController(INewsletterService newsletterService)
		{
			_newsletterService = newsletterService;
		}

		[HttpPost]
		public IActionResult Subscribe(Newsletter newsletter)
		{
			_newsletterService.TAdd(newsletter);
			return RedirectToAction("Index", "Default");
		}
	}
}
