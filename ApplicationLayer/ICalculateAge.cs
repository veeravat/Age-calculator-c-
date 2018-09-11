using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public interface ICalculateAge
    {
        int getAge(DateTime pBirthDate);
        string GetBirthDateText(DateTime pBirthDate);
    }
}
