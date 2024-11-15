using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
	public class _Card1Statistic:ViewComponent
	{
		Context context=new Context();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = context.Destinations.Count();
			ViewBag.v2 = context.Users.Count();
			return View();
		}
	}
}
