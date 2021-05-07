using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.IRepositories
{
    interface ICrudRepository<Tvalue,Tkey>:IAdd<Tvalue>,IGet<Tvalue,Tkey>,IDelete<Tvalue,Tkey>,IUpdate<Tvalue>  where Tvalue:class
    {
    }
}
