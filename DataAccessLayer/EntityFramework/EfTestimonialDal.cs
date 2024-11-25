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
	public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
	{
		Context context = new Context();
		public void ChangeToActiveByTestimonial(int id)
		{
			var values = context.Testimonials.Find(id);
			values.Status = true;
			context.Update(values);
			context.SaveChanges();
		}

		public void ChangeToPassiveByTestimonial(int id)
		{
			var values = context.Testimonials.Find(id);
			values.Status = false;
			context.Update(values);
			context.SaveChanges();
		}
	}
}
