using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class AccountController : Controller
	{
		private readonly IAccountService _accountService;

		public AccountController(IAccountService accountService)
		{
			_accountService = accountService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			List<SelectListItem> senderList = (from x in _accountService.TGetList()
											   select new SelectListItem
											   {
												   Text = x.Name,
												   Value = x.AccountId.ToString()
											   }).ToList();

			List<SelectListItem> receiverList = (from x in _accountService.TGetList()
												 select new SelectListItem
												 {
													 Text = x.Name,
													 Value = x.AccountId.ToString()
												 }).ToList();

			ViewBag.SenderList = senderList;
			ViewBag.ReceiverList = receiverList;


			return View();
		}
		[HttpPost]
		public IActionResult Index(AccountViewModel model)
		{
			if (ModelState.IsValid)
			{
				var valueSender = _accountService.TGetById(model.SenderId);
				var valueReceiver = _accountService.TGetById(model.ReceiverId);

				valueSender.Balance -= model.Amount;
				valueReceiver.Balance += model.Amount;

				List<Account> modifiedAccounts = new List<Account>()
					{
						valueSender,
						valueReceiver
					};

				_accountService.TMultiUpdate(modifiedAccounts);

				// İşlem başarılı mesajı
				TempData["SuccessMessage"] = "İşlem başarıyla gerçekleştirildi!";
				return RedirectToAction("Index");
			}

			// Hata durumunda dropdown'ları yeniden doldur
			List<SelectListItem> senderList = (from x in _accountService.TGetList()
											   select new SelectListItem
											   {
												   Text = x.Name,
												   Value = x.AccountId.ToString()
											   }).ToList();

			List<SelectListItem> receiverList = (from x in _accountService.TGetList()
												 select new SelectListItem
												 {
													 Text = x.Name,
													 Value = x.AccountId.ToString()
												 }).ToList();

			ViewBag.SenderList = senderList;
			ViewBag.ReceiverList = receiverList;
			return View(model);
		}

	}
}
