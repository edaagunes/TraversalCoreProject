using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
	[Route("Member/[controller]/[action]/{id?}")]
	public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly IReservationService _reservationService;
		private readonly UserManager<AppUser> _userManager;

		public ReservationController(UserManager<AppUser> userManager, IReservationService reservationService)
		{
			_userManager = userManager;
			_reservationService = reservationService;
		}

		public async Task<IActionResult> MyCurrentReservation()
        {
			ViewData["PageTitle"] = "Aktif Rezervasyonlar";

			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			var valuesList = _reservationService.GetListWithReservationByWaitAccepted(values.Id);
			return View(valuesList);
		}
        public async Task<IActionResult> MyOldReservation()
        {
			ViewData["PageTitle"] = "Geçmiş Rezervasyonlar";

			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			var valuesList = _reservationService.GetListWithReservationByWaitPrevious(values.Id);
			return View(valuesList);
		}

        public async Task<IActionResult> MyApprovalReservation()
        {
			ViewData["PageTitle"] = "Onay Bekleyen Rezervasyonlar";

			var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByWaitApproval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
			ViewData["PageTitle"] = "Yeni Rezervasyon";

			List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
		public async Task<IActionResult> NewReservation(Reservation reservation)
		{
			if (ModelState.IsValid)
			{
				// Kullanıcı verilerini alıyoruz
				var user = await _userManager.FindByNameAsync(User.Identity.Name);
				reservation.AppUserId = user.Id;

				if (reservation.DestinationId == 0 || reservation.AppUserId == 0)
				{
					TempData["Error"] = "Lütfen tüm alanları doldurun!";
					return RedirectToAction("NewReservation");
				}

				reservation.Status = "Onay Bekliyor";
				reservation.ReservationDate = reservation.ReservationDate.Date; // Tarih formatını düzenler

				 _reservationService.TAdd(reservation);  // Veriyi kaydediyoruz
				return RedirectToAction("MyCurrentReservation");  // Yönlendirme
			}
			return View(reservation);
		}
	}
}
