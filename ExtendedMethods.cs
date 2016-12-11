using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektroninisDienynas
{
    public static class ExtendedMethods
    {
        public static int daysRemaining(this DateTime dateTime)
        {
            DateTime now = DateTime.Now;
            return (dateTime - now).Days;
        }
    }
}
