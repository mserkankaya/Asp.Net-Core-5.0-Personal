using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {

    }
}
