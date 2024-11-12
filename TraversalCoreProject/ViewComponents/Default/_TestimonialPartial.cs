using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _TestimonialPartial:ViewComponent
	{
		TestimonialManager testimonialManager=new TestimonialManager(new EfTestimonialDal());
		public IViewComponentResult Invoke()
		{
			var values = testimonialManager.TGetList();
			return View(values);
		}
	}
}
