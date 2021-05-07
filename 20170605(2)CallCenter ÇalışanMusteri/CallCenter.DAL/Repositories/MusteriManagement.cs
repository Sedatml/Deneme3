using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
   public class MusteriManagement:ICrudRepository<Musteri,int>
    {
       CRMEntities db = new CRMEntities();
        public string Add(Musteri obj)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAll()
        {
            return db.Musteris.ToList();
        }

        public Musteri Get(int id)
        {
            throw new NotImplementedException();
        }

        public string Delete(Musteri obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(Musteri obj)
        {
            throw new NotImplementedException();
        }
    }
}
