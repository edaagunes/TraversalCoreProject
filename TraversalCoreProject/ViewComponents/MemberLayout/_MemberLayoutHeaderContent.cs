using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberLayout
{
	public class _MemberLayoutHeaderContent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			ViewBag.PageTitle = ViewContext.ViewData["PageTitle"] ?? "Traversal";
			return View();
		}
	}
}
