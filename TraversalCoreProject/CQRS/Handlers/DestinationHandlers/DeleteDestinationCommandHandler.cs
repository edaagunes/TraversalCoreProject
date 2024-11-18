using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
	public class DeleteDestinationCommandHandler
	{
		private readonly Context _context;

		public DeleteDestinationCommandHandler(Context context)
		{
			_context = context;
		}

		public void Handle(DeleteDestinationCommand command)
		{
			var values = _context.Destinations.Find(command.Id);
			_context.Destinations.Remove(values);
			_context.SaveChanges();
		}
	}
}
