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
	public class AnnouncementManager : IAnnouncementService
	{
		private readonly IAnnouncementDal _announcementDal;

		public AnnouncementManager(IAnnouncementDal announcementDal)
		{
			_announcementDal = announcementDal;
		}

		public void TAdd(Announcement entity)
		{
			_announcementDal.Insert(entity);
		}

		public void TDelete(Announcement entity)
		{
			_announcementDal.Delete(entity);
		}

		public Announcement TGetById(int id)
		{
			return _announcementDal.GetById(id);
		}

		public List<Announcement> TGetList()
		{
			return _announcementDal.GetList();
		}

		public void TUpdate(Announcement entity)
		{
			_announcementDal.Update(entity);
		}
	}
}
