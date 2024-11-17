namespace TraversalCoreProject.CQRS.Queries.DestinationQueries
{
	public class GetDestinationByIdQuery
	{
		public GetDestinationByIdQuery(int id)
		{
			this.id = id;
		}

		public int id { get; set; }
	}
}
