using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentimeterToInch
{
    // This is a class for convertion from centermeter to inch
    internal class CentimeterToInch
    {
        public static double ConvertCalculate(double centimeter)
        {
            double ans = 0.0;
            ans = centimeter / 2.54;

            return ans;
        }
    }
}
