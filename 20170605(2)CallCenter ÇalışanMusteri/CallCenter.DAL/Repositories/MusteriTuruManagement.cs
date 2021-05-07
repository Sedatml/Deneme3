using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
   public class MusteriTuruManagement:ICrudRepository<MusteriTuru,int>
    {
       CRMEntities db = new CRMEntities();
        public string Add(MusteriTuru obj)
        {
            throw new NotImplementedException();
        }

        public List<MusteriTuru> GetAll()
        {
            return db.MusteriTurus.ToList();
        }

        public MusteriTuru Get(int id)
        {
            throw new NotImplementedException();
        }

        public string Delete(MusteriTuru obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(MusteriTuru obj)
        {
            throw new NotImplementedException();
        }
    }
}
