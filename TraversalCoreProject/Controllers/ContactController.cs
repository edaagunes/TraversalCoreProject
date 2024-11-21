using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProject.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		private readonly IContactUsService _contactUsService;
		private readonly IMapper _mapper;

		public ContactController(IMapper mapper, IContactUsService contactUsService)
		{
			_mapper = mapper;
			_contactUsService = contactUsService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(SendMessageDto model) 
		{
			if (ModelState.IsValid)
			{
				_contactUsService.TAdd(new ContactUs()
				{
					MessageBody=model.MessageBody,
					Mail=model.Mail,
					MessageStatus=true,
					Name=model.Name,
					Subject=model.Subject,
					MessageDate=Convert.ToDateTime(DateTime.Now.ToShortDateString()),
				});
				return RedirectToAction("Index","Default");
			}		
			return View(model);
		}
	}
}
