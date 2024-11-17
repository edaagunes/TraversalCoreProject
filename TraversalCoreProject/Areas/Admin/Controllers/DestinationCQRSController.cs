using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.CQRS.Handlers;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class DestinationCQRSController : Controller
	{
		private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
		private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
		

		public DestinationCQRSController(GetAllDestinationQueryHandler handler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler)
		{
			_getAllDestinationQueryHandler = handler;
			_getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
		}

		public IActionResult Index()
		{
			var values = _getAllDestinationQueryHandler.Handle();
			return View(values);
		}

		public IActionResult GetDestination(int id)
		{
			var values = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery(id));
			return View(values);
		}
	}
}
