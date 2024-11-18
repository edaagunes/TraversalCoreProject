using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.AbstractUow
{
	public interface IGenericUowService<T>
	{
		void TInsert(T entity);
		void TUpdate(T entity);
		void TMultiUpdate(List<T> entities);
		List<T> TGetList();
		T TGetById(int id);
	}
}
