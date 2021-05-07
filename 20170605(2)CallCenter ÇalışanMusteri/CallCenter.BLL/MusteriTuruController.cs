using CallCenter.DAL.Repositories;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL
{
   public class MusteriTuruController
    {
       MusteriTuruManagement mtm = new MusteriTuruManagement();
       public List<MusteriTuru> Getir()
       {
          return mtm.GetAll();
       }
    }
}
