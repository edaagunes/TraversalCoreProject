using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentDal());

		[HttpGet]
		public PartialViewResult AddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult AddComment(Comment comment)
		{
			comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			comment.CommentState = true;
			commentManager.TAdd(comment);
			return RedirectToAction("Index","Destination");
		}
	}
}
