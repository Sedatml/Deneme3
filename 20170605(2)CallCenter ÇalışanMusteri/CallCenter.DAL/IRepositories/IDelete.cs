using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.IRepositories
{
    interface IDelete<Tvalue,Tkey> where Tvalue:class
    {
        string Delete(Tvalue obj);
        string Delete(Tkey id);
    }
}
