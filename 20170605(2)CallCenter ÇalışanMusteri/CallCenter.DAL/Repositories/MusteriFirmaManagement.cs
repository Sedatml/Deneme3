using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
   public class MusteriFirmaManagement:ICrudRepository<MusteriFirma,int>
    {
       CRMEntities db = new CRMEntities();
        public string Add(MusteriFirma obj)
        {
            try
            {
                db.MusteriFirmas.Add(obj);
                db.SaveChanges();
                return "Ekleme Başarılı.";
            }
            catch (Exception)
            {

                return "Ekleme Başarısız.";
            }
        }

        public List<MusteriFirma> GetAll()
        {
            return db.MusteriFirmas.ToList();
        }

        public MusteriFirma Get(int id)
        {
            return (MusteriFirma)db.MusteriFirmas.Where(mfir=>mfir.MusteriID==id);
        }

        public string Delete(MusteriFirma obj)
        {
            try
            {
                db.MusteriFirmas.Remove(obj);
                db.SaveChanges();
                return "Silme Başarılı";

            }
            catch (Exception)
            {

                return "Silme Başarısız";
            }
        }

        public string Delete(int id)
        {
            try
            {
              MusteriFirma obj=  db.MusteriFirmas.Find(id);
              db.MusteriFirmas.Remove(obj);
              return "Silme Başarılı";
            }
            catch (Exception)
            {

                return "Silme Başarısız";
            }
        }

        public string Update(MusteriFirma obj)
        {
            try
            {
                db.SaveChanges();
                return "Güncelleme Başarılı";
            }
            catch (Exception)
            {

                return "Güncelleme Başarısız";
            }
        }
    }
}
