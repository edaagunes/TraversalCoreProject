using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
	public class _GuideList:ViewComponent
	{
		GuideManager guideManager=new GuideManager(new EfGuideDal());
		public IViewComponentResult Invoke(int id)
		{
			var values = guideManager.TGetListWithDestinations();
			return View(values);
		}
	}
}
