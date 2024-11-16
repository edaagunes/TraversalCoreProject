using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DestinationController : Controller
	{
		private readonly IDestinationService _destinationService;

		public DestinationController(IDestinationService destinationService)
		{
			_destinationService = destinationService;
		}

		public IActionResult Index()
		{
			var values = _destinationService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddDestination()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddDestination(Destination destination)
		{
			_destinationService.TAdd(destination);
			return RedirectToAction("Index","Destination", new { area = "Admin" });
		}
		public IActionResult DeleteDestination(int id)
		{ 
			var values=_destinationService.TGetById(id);
			_destinationService.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateDestination(int id)
		{
			var values = _destinationService.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateDestination(Destination destination)
		{
			_destinationService.TUpdate(destination);
			return RedirectToAction("Index");
		}
	}
}
