using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
   public class EmailManagement:ICrudRepository<Email,int>
    {
       CRMEntities db = new CRMEntities();
        public string Add(Email obj)
        {
            try
            {
                db.Emails.Add(obj);
                db.SaveChanges();
                return "Ekleme Başarılı.";
            }
            catch (Exception)
            {

                return "Ekleme Başarısız.";
            }
        }

        public List<Email> GetAll()
        {
            return db.Emails.ToList();
        }

        public Email Get(int id)
        {
            Email obj = db.Emails.Find(id);
            return obj;
        }

        public string Delete(Email obj)
        {
            try
            {
                db.Emails.Remove(obj);
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
                Email obj = (Email)db.Emails.Where(e => e.MusteriID == id);

                db.Emails.Remove(obj);
                db.SaveChanges();
                return "Silme Başarılı.";
            }
            catch (Exception)
            {

                return "Silme Başarısız.";
            }
        }

        public string Update(Email obj)
        {
            try
            {

                db.SaveChanges();
                return "silme başarılı.";
            }
            catch (Exception)
            {

                return "silme başarısız.";
            }
        }
    }
}
