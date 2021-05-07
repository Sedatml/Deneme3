using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
   public class MusteriBireyManagement:ICrudRepository<MusteriBireysel,int>
    {
       CRMEntities db = new CRMEntities();
        public string Add(MusteriBireysel obj)
        {
            try
            {
                db.MusteriBireysels.Add(obj);
                db.SaveChanges();
                return "Ekleme Başarılı.";
            }
            catch (Exception)
            {

                return "Ekleme Başarısız.";
            }
        }

        public List<MusteriBireysel> GetAll()
        {
            return db.MusteriBireysels.ToList();
        }

        public MusteriBireysel Get(int id)
        {
            MusteriBireysel obj = db.MusteriBireysels.Find(id); 
            return obj;
        }

        public string Delete(MusteriBireysel obj)
        {
            try
            {
                db.MusteriBireysels.Remove(obj);
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
                MusteriBireysel obj = (MusteriBireysel)db.MusteriBireysels.Where(mus => mus.MusteriID == id);

                db.MusteriBireysels.Remove(obj);
                db.SaveChanges();
                return "Silme Başarılı.";
            }
            catch (Exception)
            {

                return "Silme Başarısız.";
            }
        }

        public string Update(MusteriBireysel obj)
        {
            try
            {
               
                db.SaveChanges();
                return "Guncelleme başarılı.";
            }
            catch (Exception)
            {

                return "Guncelleme başarısız.";
            }
        }
    }
}
