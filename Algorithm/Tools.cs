using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public static class Tools
    {
        public static int ToInt(this object obje)
        {
            return Convert.ToInt32(obje);
        }

        public static decimal ToDecimal(this object obje)
        {
            return Convert.ToDecimal(obje);
        }

        public static string ToDateTime(this DateTime date)
        {
            return date.ToString("dd/MM/yy");
        }

        public static bool IsNegativeNumber(this int num1)
        {
            return num1< 0;
        }

    }
}