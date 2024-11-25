using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class UserController : Controller
	{
		private readonly IAppUserService _userService;
		private readonly IReservationService _reservationService;
		private readonly ICommentService _commentService;

		public UserController(IAppUserService userService, IReservationService reservationService, ICommentService commentService)
		{
			_userService = userService;
			_reservationService = reservationService;
			_commentService = commentService;
		}

		public IActionResult Index()
		{
			var values = _userService.TGetList();
			return View(values);
		}
		public IActionResult DeleteUser(int id)
		{
			var values = _userService.TGetById(id);
			_userService.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditUser(int id)
		{
			var values = _userService.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditUser(AppUser appUser)
		{
			var existingUser = _userService.TGetById(appUser.Id);
			if (existingUser == null)
			{
				return NotFound("Kullanıcı bulunamadı.");
			}

			// Mevcut kullanıcı bilgilerini güncelle
			existingUser.Name = appUser.Name;
			existingUser.Surname = appUser.Surname;
			existingUser.UserName = appUser.UserName;
			existingUser.Email = appUser.Email;

			_userService.TUpdate(existingUser);
			return RedirectToAction("Index");
		}
		public IActionResult CommentUser(int id)
		{
			var existingUser = _userService.TGetById(id);
			ViewBag.user=existingUser.Name +" "+ existingUser.Surname;

			var values=_commentService.TGetListCommentWithUser(id);
			return View(values);
		}
		public IActionResult ReservationUser(int id)
		{
			var values = _reservationService.GetListWithReservationByWaitAccepted(id);
			return View(values);
		}
	}
}
