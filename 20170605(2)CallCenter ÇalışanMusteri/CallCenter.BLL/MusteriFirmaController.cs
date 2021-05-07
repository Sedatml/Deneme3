using CallCenter.DAL.Repositories;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL
{
   public class MusteriFirmaController
    {
        MusteriFirmaManagement musm = new MusteriFirmaManagement();

        public void Ekle(MusteriFirma musteri)
        {
            musm.Add(musteri);
        }
        public List<MusteriFirma> Getir()
        {
            return musm.GetAll();
        }
    }
}
