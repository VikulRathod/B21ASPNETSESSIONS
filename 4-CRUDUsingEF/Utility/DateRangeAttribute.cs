using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4_CRUDUsingEF.Utility
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute(string minimumDate) :
            base(typeof(DateTime), minimumDate, DateTime.Now.ToString())
        {

        }
    }
}