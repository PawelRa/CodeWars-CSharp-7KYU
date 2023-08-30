using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Coupon_Code
{
    public static class Kata
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            if (enteredCode == correctCode)
            {
                if (DateOnly.Parse(expirationDate) >= DateOnly.Parse(currentDate))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
