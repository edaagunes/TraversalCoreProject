using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers
{
	public class GetDestinationByIdQueryHandler
	{
		private readonly Context _context;

		public GetDestinationByIdQueryHandler(Context context)
		{
			_context = context;
		}

		public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
		{
			var values = _context.Destinations.Find(query.id);
			return new GetDestinationByIdQueryResult
			{
				Destinationid = values.DestinationId,
				City = values.City,
				DayNight = values.DayNight,
			};
		}
	}
}
