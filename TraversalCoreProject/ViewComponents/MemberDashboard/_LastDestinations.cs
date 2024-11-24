using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
	public class _LastDestinations : ViewComponent
	{
		private readonly IDestinationService _destinationService;

		public _LastDestinations(IDestinationService destinationService)
		{
			_destinationService = destinationService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_destinationService.TGetLast4Destinations();
			
			return View(values);
		}
	}
}
