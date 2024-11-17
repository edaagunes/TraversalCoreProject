using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
	public class GetAllDestinationQueryHandler
	{
		private readonly Context _context;

		public GetAllDestinationQueryHandler(Context context)
		{
			_context = context;
		}

		public List<GetAllDestinationQueryResult> Handle()
		{
			var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
			{
				capacity = x.Capacity,
				city = x.City,
				dayNight = x.DayNight,
				id = x.DestinationId,
				price = x.Price
			}).AsNoTracking().ToList();
			return values;
		}
	}
}
