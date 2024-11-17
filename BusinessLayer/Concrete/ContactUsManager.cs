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
	public class ContactUsManager : IContactUsService
	{
		IContactUsDal _contactUsDal;

		public ContactUsManager(IContactUsDal contactUsDal)
		{
			_contactUsDal = contactUsDal;
		}

		public void TAdd(ContactUs entity)
		{
			throw new NotImplementedException();
		}

		public void TContactUsStatusChangeToFalse(int id)
		{
			throw new NotImplementedException();
		}

		public void TDelete(ContactUs entity)
		{
			throw new NotImplementedException();
		}

		public ContactUs TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<ContactUs> TGetList()
		{
			return _contactUsDal.GetList();
		}

		public List<ContactUs> TGetListByContactUsFalse()
		{
			return _contactUsDal.GetListByContactUsFalse();
		}

		public List<ContactUs> TGetListByContactUsTrue()
		{
			return _contactUsDal.GetListByContactUsTrue();
		}

		public void TUpdate(ContactUs entity)
		{
			throw new NotImplementedException();
		}
	}
}
