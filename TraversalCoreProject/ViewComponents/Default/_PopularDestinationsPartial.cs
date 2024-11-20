using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _PopularDestinationsPartial : ViewComponent
	{
		DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
		public IViewComponentResult Invoke()
		{
			var values = destinationManager.TGetList().Take(8).ToList();
			return View(values);
		}
	}
}
