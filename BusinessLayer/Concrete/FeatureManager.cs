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
	public class FeatureManager : IFeatureService
	{
		IFeatureDal _featureDal;

		public FeatureManager(IFeatureDal featureDal)
		{
			_featureDal = featureDal;
		}

		public void TAdd(Feature entity)
		{
			throw new NotImplementedException();
		}

		public void TChangeToActiveByFeature(int id)
		{
			_featureDal.ChangeToActiveByFeature(id);
		}

		public void TChangeToPassiveByFeature(int id)
		{
			_featureDal.ChangeToPassiveByFeature(id);
		}

		public void TDelete(Feature entity)
		{
			throw new NotImplementedException();
		}

		public Feature TGetById(int id)
		{
			return _featureDal.GetById(id);
		}

		public List<Feature> TGetList()
		{
			return _featureDal.GetList();
		}

		public void TUpdate(Feature entity)
		{
			throw new NotImplementedException();
		}
	}
}
