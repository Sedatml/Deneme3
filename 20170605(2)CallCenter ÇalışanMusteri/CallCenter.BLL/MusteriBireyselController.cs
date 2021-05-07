using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.DAL.Repositories;
using Entity;

namespace CallCenter.BLL
{
   public class MusteriBireyselController
    {
       MusteriBireyManagement musm = new MusteriBireyManagement();

       public void Ekle(MusteriBireysel musteri)
       {
           musm.Add(musteri);
       }
       public List<MusteriBireysel> Getir()
       {
           return musm.GetAll();
       }
       public MusteriBireysel Getir(int id)
       {
           return musm.Get(id);
       }

       public void Guncelle(MusteriBireysel musteri)
       {
           musm.Update(musteri);
       }


    }
}
