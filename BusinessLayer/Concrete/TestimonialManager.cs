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
	public class TestimonialManager : ITestimonialService
	{
		ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

		public void TAdd(Testimonial entity)
		{
			_testimonialDal.Insert(entity);
		}

		public void TChangeToActiveByTestimonial(int id)
		{
			_testimonialDal.ChangeToActiveByTestimonial(id);
		}

		public void TChangeToPassiveByTestimonial(int id)
		{
			_testimonialDal.ChangeToPassiveByTestimonial(id);
		}

		public void TDelete(Testimonial entity)
		{
			throw new NotImplementedException();
		}

		public Testimonial TGetById(int id)
		{
			return _testimonialDal.GetById(id);
		}

		public List<Testimonial> TGetList()
		{
			return _testimonialDal.GetList();
		}

		public void TUpdate(Testimonial entity)
		{
			_testimonialDal.Update(entity);
		}
	}
}
