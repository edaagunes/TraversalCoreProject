using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TDelete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public Comment TGetById(int id)
        {
           return _commentDal.GetById(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationId == id);
        }

        public void TUpdate(Comment entity)
        {
            throw new NotImplementedException();
        }

		public List<Comment> TGetListCommentWithDestination()
		{
			return _commentDal.GetListCommentWithDestination();
		}

        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }
	}
}
