using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer;

namespace BusniessLayer
{
    public class CalulateAgeTH : ApplicationLayer.ICalculateAge
    {
        public int getAge(DateTime pBirthDate)
        {
            return pBirthDate.Age();
        }

        public string GetBirthDateText(DateTime pBirthDate)
        {
            return pBirthDate.ToString("วันddddที่ d MMMM พ.ศ. yyyy",
                CultureInfo.GetCultureInfo("th-TH"));
        }
    }
}
