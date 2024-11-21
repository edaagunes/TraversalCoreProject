using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
	[AllowAnonymous]
	public class DestinationController : Controller
	{
		DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
		CommentManager commentManager = new CommentManager(new EfCommentDal());
		private readonly UserManager<AppUser> _userManager;

		public DestinationController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			var values = destinationManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public async Task<IActionResult> DestinationDetails(int id)
		{
			ViewBag.i=id;
			ViewBag.destId=id;

			var value = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.userId = value.Id;

			var values = destinationManager.TGetDestinationWithGuide(id);
			return View(values);
		}
		//[HttpPost]
		//public IActionResult DestinationDetails(Destination destination)
		//{
		//	return View();
		//}
	}
}
