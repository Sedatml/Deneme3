using CallCenter.DAL.Repositories;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL
{
    public class TelefonController
    {
        TelefonManagement tm = new TelefonManagement();
        public void Ekle(Telefon telefon)
        {
            tm.Add(telefon);
        }
        public Telefon Getir(int id)
        {
            return tm.Get(id);
        }
        public void Guncelle(Telefon obj)
        {
            tm.Update(obj);
        }
    }
}
