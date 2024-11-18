using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
	public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
	{
		private readonly Context _context;

		public GenericUowRepository(Context context)
		{
			_context = context;
		}

		public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			return _context.Set<T>().ToList(); 
		}

		public void Insert(T entity)
		{
			_context.Add(entity);
		}

		public void MultiUpdate(List<T> entities)
		{
			_context.UpdateRange(entities);
		}

		public void Update(T entity)
		{
			_context.Update(entity);
		}
	}
}
