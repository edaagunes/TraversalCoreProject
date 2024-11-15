using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
	public class _DashboardBanner:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
