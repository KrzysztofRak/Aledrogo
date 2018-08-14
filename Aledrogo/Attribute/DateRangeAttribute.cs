using System;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Attribute
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute(int minDurationInDays, int maxDurationInDays) 
            : base(typeof(DateTime), DateTime.UtcNow.AddDays(minDurationInDays).ToString(), DateTime.UtcNow.AddDays(maxDurationInDays).ToString()) { }
    }
}
