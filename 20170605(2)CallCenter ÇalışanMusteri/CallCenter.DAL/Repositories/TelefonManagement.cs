using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.IRepositories;
using Entity;

namespace CallCenter.DAL.Repositories
{
   public class TelefonManagement:ICrudRepository<Telefon,int>
    {
       CRMEntities db=new CRMEntities();


       public string Add(Telefon obj)
       {
           try
           {
               db.Telefons.Add(obj);
               db.SaveChanges();
               return "Ekleme Başarılı.";
           }
           catch (Exception)
           {

               return "Ekleme Başarısız.";
           }
       }

       public List<Telefon> GetAll()
       {
           throw new NotImplementedException();
       }

       public Telefon Get(int id)
       {
           Telefon obj = db.Telefons.Find(id);
           return obj;
       }

       public string Delete(Telefon obj)
       {
           throw new NotImplementedException();
       }

       public string Delete(int id)
       {
           throw new NotImplementedException();
       }

       public string Update(Telefon obj)
       {
           try
           {
               db.SaveChanges();
               return "Güncelleme Başarılı.";
           }
           catch (Exception)
           {
               
               return "Güncelleme Başarısız.";
           }
   
       }
    }
}
