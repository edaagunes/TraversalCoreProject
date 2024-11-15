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
			throw new NotImplementedException();
		}

		public void TDelete(Guide entity)
		{
			throw new NotImplementedException();
		}

		public Guide TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Guide> TGetList()
		{
			return _guideDal.GetList();
		}

		public void TUpdate(Guide entity)
		{
			throw new NotImplementedException();
		}
	}
}
