using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _FeaturePartial : ViewComponent
	{
		FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
		public IViewComponentResult Invoke()
		{
			var values=featureManager.TGetList();
			return View(values);
		}
	}
}
