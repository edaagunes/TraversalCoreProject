using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class TestimonialController : Controller
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		public IActionResult Index()
		{
			var values = _testimonialService.TGetList();
			return View(values);
		}

		public IActionResult ChangeToPassive(int id)
		{
			_testimonialService.TChangeToPassiveByTestimonial(id);
			return RedirectToAction("Index", "Testimonial", new { area = "Admin" });
		}

		public IActionResult ChangeToActive(int id)
		{
			_testimonialService.TChangeToActiveByTestimonial(id);
			return RedirectToAction("Index", "Testimonial", new { area = "Admin" });
		}

		[HttpGet]
		public IActionResult EditTestimonial(int id)
		{
			var values = _testimonialService.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditTestimonial(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult AddTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.TAdd(testimonial);
			return RedirectToAction("Index");
		}
	}
}
