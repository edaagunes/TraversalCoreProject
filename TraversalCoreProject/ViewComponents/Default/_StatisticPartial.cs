using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _StatisticPartial : ViewComponent
	{
		
		public IViewComponentResult Invoke()
		{
			using var c=new Context();
			ViewBag.v1 = c.Destinations.Count();
			ViewBag.v2 = c.Guides.Count();
			ViewBag.v3 = "285";
			return View();
		}
	}
}
