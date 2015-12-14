using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
using Model;
using Test.Base;

namespace Test.Helper
{
   public  class EventOrganizerHelper
    {
       
        private readonly UnitofWork _uow;

        public EventOrganizerHelper()
        {
            _uow = new Uow().AllRepo();
        }
    }
}
