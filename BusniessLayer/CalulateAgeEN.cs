using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer
{
    public class CalulateAgeEN : ApplicationLayer.ICalculateAge
    {
        public int getAge(DateTime pBirthDate)
        {
            return pBirthDate.Age();
        }

        public string GetBirthDateText(DateTime pBirthDate)
        {
            return pBirthDate.ToString("MMM ddd d, yyyy",
                CultureInfo.GetCultureInfo("en-US"));
        }
    }
}
