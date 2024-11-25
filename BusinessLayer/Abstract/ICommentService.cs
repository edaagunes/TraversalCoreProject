using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService : IGenericService<Comment>
	{
		List<Comment> TGetListCommentWithDestination();
		public List<Comment> TGetListCommentWithDestinationAndUser(int id);
		List<Comment> TGetListCommentWithUser(int userId);  // Kullanıcıya göre yorumları al
		public Comment TGetComment(int id);
	}
}
