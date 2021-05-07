using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
  public  class BireyUnvanManagemenet:ICrudRepository<BireyselUnvan,int>
    {
      CRMEntities db = new CRMEntities();

        public string Add(BireyselUnvan obj)
        {
            try
            {
              db.BireyselUnvans.Add(obj);
                db.SaveChanges();
                return "Ekleme Başarılı.";
            }
            catch (Exception)
            {

                return "Ekleme Başarısız.";
            }
        }

        public List<BireyselUnvan> GetAll()
        {
            return db.BireyselUnvans.ToList();
        }

        public BireyselUnvan Get(int id)
        {
            BireyselUnvan obj = db.BireyselUnvans.Find(id);
            return obj;

        }

        public string Delete(BireyselUnvan obj)
        {
            try
            {
                db.BireyselUnvans.Remove(obj);
                db.SaveChanges();
                return "Silme Başarılı.";
            }
            catch (Exception)
            {

                return "Silme Başarısız.";
            }
        }

        public string Delete(int id)
        {
            try
            {
                MusteriBireysel obj = db.MusteriBireysels.Find(id);
                db.MusteriBireysels.Remove(obj);
                db.SaveChanges();
                return "Silme Başarılı.";
            }
            catch (Exception)
            {

                return "Silme Başarısız.";
            }
        }

        public string Update(BireyselUnvan obj)
        {
            try
            {
                db.BireyselUnvans.Remove(obj);
                db.SaveChanges();
                return "Silme Başarılı.";
            }
            catch (Exception)
            {

                return "Silme Başarısız.";
            }
        }
    }
}
