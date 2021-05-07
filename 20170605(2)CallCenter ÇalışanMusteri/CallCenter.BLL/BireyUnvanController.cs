using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.Repositories;
using Entity;

namespace CallCenter.BLL
{
   public class BireyUnvanController
    {

       BireyUnvanManagemenet bum = new BireyUnvanManagemenet();

       public List<BireyselUnvan> Getir()
       {
          return bum.GetAll();
       }
       public BireyselUnvan Getir(int id)
       {
           return bum.Get(id);
       }
       public void Guncelle(BireyselUnvan obj)
       {
           bum.Update(obj);
       }

    }
}
