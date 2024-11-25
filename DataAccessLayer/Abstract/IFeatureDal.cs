using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IFeatureDal : IGenericDal<Feature>
    {
		void ChangeToActiveByFeature(int id);
		void ChangeToPassiveByFeature(int id);

	}
}
