using System;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Attribute
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute(int addDayToBeginDate, int addDayToEndDate) 
            : base(typeof(DateTime), DateTime.UtcNow.AddDays(addDayToBeginDate).ToString(), DateTime.UtcNow.AddDays(addDayToEndDate).ToString()) { }
    }
}
