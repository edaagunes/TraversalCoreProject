using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
	[Area("Member")]
	[Route("Member/[controller]/[action]/{id?}")]
	public class DashboardController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly IDestinationService _destinationService;

		public DashboardController(UserManager<AppUser> userManager, IDestinationService destinationService)
		{
			_userManager = userManager;
			_destinationService = destinationService;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.userName = values.Name + " " + values.Surname;
			ViewBag.userImage = values.ImageUrl;			

			return View();
		}
	}
}
