using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Fake.Model.Util
{
   public class DateUtil
    {
       public DateTime GetTimeZone(DateTime d)
       {
           string dateString = "Mon 16 Jun 8:30 AM 2008"; // <-- Never existed!
           string format = "ddd dd MMM h:mm tt yyyy";
           DateTime dateTime = DateTime.ParseExact(dateString,
               format, CultureInfo.InvariantCulture);
           return dateTime;
       }
    }
}
