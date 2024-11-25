using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFeatureService : IGenericService<Feature>
    {
		void TChangeToActiveByFeature(int id);
		void TChangeToPassiveByFeature(int id);
	}
}
