using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IContactUsService : IGenericService<ContactUs>
	{
		List<ContactUs> TGetListByContactUsTrue();
		List<ContactUs> TGetListByContactUsFalse();
		void TContactUsStatusChangeToFalse(int id);
	}
}
