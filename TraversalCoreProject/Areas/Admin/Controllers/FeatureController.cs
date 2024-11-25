using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class FeatureController : Controller
	{
		private readonly IFeatureService _featureService;

		public FeatureController(IFeatureService featureService)
		{
			_featureService = featureService;
		}

		public IActionResult Index()
		{
			var values = _featureService.TGetList();
			return View(values);
		}

		public IActionResult ChangeToPassive(int id)
		{ 
			_featureService.TChangeToPassiveByFeature(id);
			return RedirectToAction("Index", "Feature", new { area = "Admin" });
		}

		public IActionResult ChangeToActive(int id)
		{
			_featureService.TChangeToActiveByFeature(id);
			return RedirectToAction("Index", "Feature", new { area = "Admin" });
		}
	}
}
