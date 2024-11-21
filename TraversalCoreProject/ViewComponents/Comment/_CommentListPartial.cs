using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentListPartial : ViewComponent
    {
        CommentManager commentManager=new CommentManager(new EfCommentDal());
        Context context =new Context();

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount=context.Comments.Where(x=>x.DestinationId==id).Count();
            var values=commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
