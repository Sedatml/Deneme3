using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
   public class AdresManagement:ICrudRepository<Adre,int>
    {
       CRMEntities db = new CRMEntities();
        public string Add(Adre obj)
        {
            throw new NotImplementedException();
        }

        public List<Adre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Adre Get(int id)
        {
            Adre obj = db.Adres.Find(id);
            return obj;
        }

        public string Delete(Adre obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(Adre obj)
        {
            try
            {
                db.SaveChanges();
                return "Guncelleme Başarılı.";
            }
            catch (Exception)
            {

                return "Guncelleme Başarısız.";
            }
        }
    }
}
