using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Mabit.Services.Helper
{
    public static class HelperMethod
    {
        public static string PersianToEnglish(this string persianStr)
        {
            Dictionary<string, string> LettersDictionary = new Dictionary<string, string>
            {
                ["۰"] = "0",
                ["۱"] = "1",
                ["۲"] = "2",
                ["۳"] = "3",
                ["۴"] = "4",
                ["۵"] = "5",
                ["۶"] = "6",
                ["۷"] = "7",
                ["۸"] = "8",
                ["۹"] = "9"
            };
            return LettersDictionary.Aggregate(persianStr, (current, item) =>
                         current.Replace(item.Key, item.Value));
        }
        public static string ToGregorianDate(this string value)
        {
            value = value.PersianToEnglish();
            //value = value + " 12:00:00";
            //var dt = System.DateTime.Parse(value, new CultureInfo("fa-IR"));
            //return dt.ToUniversalTime();
            var year = Convert.ToInt32(value.Split('/')[0]);
            var month = Convert.ToInt32(value.Split('/')[1]);
            var day = Convert.ToInt32(value.Split('/')[2]);
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(year, month, day, pc);
            return dt.ToString(CultureInfo.InvariantCulture);
        }
    }
}
