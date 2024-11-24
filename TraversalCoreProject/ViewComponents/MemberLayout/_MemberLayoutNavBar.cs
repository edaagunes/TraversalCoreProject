using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.MemberLayout
{
	public class _MemberLayoutNavBar : ViewComponent
	{
		private readonly UserManager<AppUser> _userManager;

		public _MemberLayoutNavBar(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.userName = values.Name + " " + values.Surname;
			ViewBag.userImage = values.ImageUrl;
			return View();
		}
	}
}
