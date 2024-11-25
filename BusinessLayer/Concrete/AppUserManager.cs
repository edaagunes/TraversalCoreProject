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
	public class AppUserManager : IAppUserService
	{
		IAppUserDal _appUserDal;

		public AppUserManager(IAppUserDal appUserDal)
		{
			_appUserDal = appUserDal;
		}

		public void TAdd(AppUser entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(AppUser entity)
		{
			_appUserDal.Delete(entity);
		}

		public AppUser TGetById(int id)
		{
			return _appUserDal.GetById(id);
		}

		public List<AppUser> TGetList()
		{
			return _appUserDal.GetList();
		}

		public void TUpdate(AppUser entity)
		{
			_appUserDal.Update(entity);
		}
	}
}
