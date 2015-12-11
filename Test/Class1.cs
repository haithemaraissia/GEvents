using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    static  class Class1
    {
         static void Main()
        {
             var _uow = new Uow().AllRepo();
        }
            
    }
}
