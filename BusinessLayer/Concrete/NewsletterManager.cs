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
	public class NewsletterManager : INewsletterService
	{
		INewsletterDal _newsletterDal;

		public NewsletterManager(INewsletterDal newsletterDal)
		{
			_newsletterDal = newsletterDal;
		}

		public void TAdd(Newsletter entity)
		{
			_newsletterDal.Insert(entity);
		}

		public void TDelete(Newsletter entity)
		{
			throw new NotImplementedException();
		}

		public Newsletter TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Newsletter> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Newsletter entity)
		{
			throw new NotImplementedException();
		}
	}
}
