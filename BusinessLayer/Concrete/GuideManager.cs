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
	public class GuideManager : IGuideService
	{
		IGuideDal _guideDal;

		public GuideManager(IGuideDal guideDal)
		{
			_guideDal = guideDal;
		}

		public void TAdd(Guide entity)
		{
			_guideDal.Insert(entity);
		}

		public void TChangeToActiveByGuide(int id)
		{
			_guideDal.ChangeToActiveByGuide(id);
		}

		public void TChangeToPassiveByGuide(int id)
		{
			_guideDal.ChangeToPassiveByGuide(id);
		}

		public void TDelete(Guide entity)
		{
			_guideDal.Delete(entity);
		}

		public Guide TGetById(int id)
		{
			return _guideDal.GetById(id);
		}

		public List<Guide> TGetList()
		{
			return _guideDal.GetList();
		}

		public void TUpdate(Guide entity)
		{
			_guideDal.Update(entity);
		}
	}
}
