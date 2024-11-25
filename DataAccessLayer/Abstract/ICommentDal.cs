using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface ICommentDal : IGenericDal<Comment>
	{
		public List<Comment> GetListCommentWithDestination();
		public List<Comment> GetListCommentWithDestinationAndUser(int id);
		public List<Comment> GetListCommentWithUser(int userId);

		public Comment GetComment(int id);
	}
}
