using CallCenter.DAL.Repositories;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL
{
  public class EmailController
    {
      EmailManagement emm = new EmailManagement();

      public List<Email> Getir()
      {
          return emm.GetAll();
      }
      public Email Getir(int ıd)
      {
          return emm.Get(ıd);
      }
      public void Guncelle(Email obj)
      {
          emm.Update(obj);
      }
    }
}
