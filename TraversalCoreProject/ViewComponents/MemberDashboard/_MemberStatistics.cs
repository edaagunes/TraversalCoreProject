using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
	public class _MemberStatistics : ViewComponent
	{
		private readonly IReservationService _reservationService;
		private readonly IGuideService _guideService;
		private readonly IAppUserService _appUserService;
		private readonly IDestinationService _destinationService;

		public _MemberStatistics(IReservationService reservationService, IGuideService guideService, IAppUserService appUserService, IDestinationService destinationService)
		{
			_reservationService = reservationService;
			_guideService = guideService;
			_appUserService = appUserService;
			_destinationService = destinationService;
		}

		public IViewComponentResult Invoke()
		{
			// Giriş yapan kullanıcının ID'sini almak için ClaimsPrincipal'a dönüştürme
			var userId = int.Parse(((ClaimsPrincipal)User).FindFirstValue(ClaimTypes.NameIdentifier));
			ViewBag.UserId = userId;

			ViewBag.destAccept=_reservationService.GetListWithReservationByWaitAccepted(userId).Count();
			ViewBag.destApproval=_reservationService.GetListWithReservationByWaitApproval(userId).Count();
			ViewBag.destOld=_reservationService.GetListWithReservationByWaitPrevious(userId).Count();
		

			ViewBag.guideCount = _guideService.TGetList().Count();
			ViewBag.totalUsers=_appUserService.TGetList().Count();
			ViewBag.totalDestinations=_destinationService.TGetList().Count();
			return View();
		}
	}
}
