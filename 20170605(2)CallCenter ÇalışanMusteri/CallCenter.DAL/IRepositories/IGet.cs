using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.IRepositories
{
    interface IGet<Tvalue,Tkey> where Tvalue:class
    {
        List<Tvalue> GetAll();
        Tvalue Get(Tkey id);
    }
}
