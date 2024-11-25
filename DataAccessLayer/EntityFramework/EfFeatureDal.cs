using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
		Context context = new Context();
		public void ChangeToActiveByFeature(int id)
		{
			var values = context.Features.Find(id);
			values.Status = true;
			context.Update(values);
			context.SaveChanges();
		}

		public void ChangeToPassiveByFeature(int id)
		{
			var values = context.Features.Find(id);
			values.Status = false;
			context.Update(values);
			context.SaveChanges();
		}

	}
}
