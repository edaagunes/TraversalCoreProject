using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class MailController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(MailRequest mailRequest)
		{
			try
			{
				MimeMessage mimeMessage = new MimeMessage();

				MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversalcoreeda@gmail.com");
				mimeMessage.From.Add(mailboxAddressFrom);

				MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
				mimeMessage.To.Add(mailboxAddressTo);

				var bodyBuilder = new BodyBuilder();
				bodyBuilder.TextBody = mailRequest.Body;
				mimeMessage.Body = bodyBuilder.ToMessageBody();

				mimeMessage.Subject = mailRequest.Subject;

				SmtpClient client = new SmtpClient();
				client.Connect("smtp.gmail.com", 587, false);
				client.Authenticate("traversalcoreeda@gmail.com", "ktae jpiv ywkt fcof");
				client.Send(mimeMessage);
				client.Disconnect(true);

				TempData["SuccessMessage"] = "Mail başarılı bir şekilde gönderildi.";
			}
			catch (Exception)
			{
				TempData["ErrorMessage"] = "Mail gönderimi sırasında bir hata oluştu.";
			}
			

			return View();
		}
	}
}
