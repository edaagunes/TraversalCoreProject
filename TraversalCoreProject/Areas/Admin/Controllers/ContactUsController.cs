using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class ContactUsController : Controller
	{
		private readonly IContactUsService _contactUsService;

		public ContactUsController(IContactUsService contactUsService)
		{
			_contactUsService = contactUsService;
		}

		public IActionResult Index()
		{
			var values = _contactUsService.TGetListByContactUsTrue();
			return View(values);
		}

		public IActionResult DeleteMessage(int id)
		{
			var values=_contactUsService.TGetById(id);
			_contactUsService.TDelete(values);
			return RedirectToAction("Index");
		}

		public IActionResult DetailMessage(int id)
		{
			var values = _contactUsService.TGetById(id);
			return View(values);
		}
	}
}
