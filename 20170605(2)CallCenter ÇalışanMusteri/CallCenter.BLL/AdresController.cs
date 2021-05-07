using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using CallCenter.DAL.Repositories;

namespace CallCenter.BLL
{
   public class AdresController
    {
        AdresManagement adrm = new AdresManagement();
        public void Ekle(Adre telefon)
        {
            adrm.Add(telefon);
        }

        public Adre Getir(int id)
        {
           return adrm.Get(id);
        }
        public void Guncelle(Adre obj)
        {
            adrm.Update(obj);
        }
    }
}
