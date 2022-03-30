using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public class DateUtil
    {
        public bool IsDateValid(DateTime bookingDate)
        {
            return bookingDate < DateTime.Now ? true : false;
        }
    }
}
