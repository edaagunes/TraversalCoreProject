using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfGuideDal : GenericRepository<Guide>, IGuideDal
	{
		Context context = new Context();
		public void ChangeToActiveByGuide(int id)
		{			
			var values = context.Guides.Find(id);
			values.Status = true;
			context.Update(values);
			context.SaveChanges();
		}

		public void ChangeToPassiveByGuide(int id)
		{
			var values = context.Guides.Find(id);
			values.Status = false;
			context.Update(values);
			context.SaveChanges();
		}

		public List<Guide> GetListWithDestinations()
		{
			
			return context.Guides.Include(g => g.Destinations).ToList();
			
		}
	}
}
