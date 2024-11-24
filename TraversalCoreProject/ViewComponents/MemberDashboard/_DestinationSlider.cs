using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
	public class _DestinationSlider:ViewComponent
	{
		private readonly IDestinationService _destinationService;

		public _DestinationSlider(IDestinationService destinationService)
		{
			_destinationService = destinationService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _destinationService.TGetList().Take(6);
			return View(values);
		}
	}
}
