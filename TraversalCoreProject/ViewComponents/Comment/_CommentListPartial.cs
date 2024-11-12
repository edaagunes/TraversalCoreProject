using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
	public class _CommentListPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{ return View(); }
	}
}
